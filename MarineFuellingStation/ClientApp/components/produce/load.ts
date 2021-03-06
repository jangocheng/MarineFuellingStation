﻿import ComponentBase from "../../ComponentBase";
import { Component } from 'vue-property-decorator';
import axios from "axios";

@Component
export default class LoadComponent extends ComponentBase {
    carNo: string = "";

    order: server.order;
    orders: server.order[];
    store: server.store;
    stores: server.store[];
    workers: work.userlist[];
    worker: string = "";
    title: string = "";
    currStep: number = 0;
    page: number = 1;
    showOrders: boolean = false;
    showStores: boolean = false;

    carOrBoat: string = "船号";

    orderType: server.salesPlanType;

    oid: string;//路由传值oid

    showSelectWorker: boolean = true;

    constructor() {
        super();

        this.order = new Object as server.order;
        this.order.store = new Object as server.store;
        this.orders = new Array<server.order>();
        this.store = new Object as server.store;
        this.stores = new Array<server.store>();
        this.workers = new Array<work.userlist>();
        this.worker = "";
    }

    mounted() {
        //默认的施工人员为操作人
        this.order.worker = this.$store.state.username;

        this.oid = this.$route.params.oid;
        this.orderType = parseInt(this.$route.params.ordertype) as server.salesPlanType;
        switch (this.orderType) {
            case server.salesPlanType.水上加油:
                this.title = "水上加油";
                this.carOrBoat = "船号";
                break;
            case server.salesPlanType.汇鸿车辆加油:
                this.title = "汇鸿车辆加油"
                this.carOrBoat = "车牌号"
                break;
            case server.salesPlanType.外来车辆加油:
                this.title = "外来车辆加油"
                this.carOrBoat = "车牌号"
                break;
        }
        if (this.oid) {
            let that = this;
            this.getOrder(this.oid, () => {
                that.initData();
            });
        }
        else {
            this.getStores();
            this.getWorkers();
        }
    };

    initData() {
        this.getStores();
        this.getWorkers();
    }

    workerSelectedClick() {
        this.showSelectWorker = false;
        this.$emit("setTitle", this.worker + ' ' + this.title)
    }

    showOrdersclick() {
        this.showOrders = true;
        this.getOrders(1);
    }

    orderclick(o: server.order) {
        this.order = o;
        this.showOrders = false;
        //console.log(this.order);
        this.matchCurrStep();

    }
    matchCurrStep() {
        if (this.order.state == server.orderState.已开单) this.currStep = 1;
        if (this.order.state == server.orderState.装油中) this.currStep = 2;
        if (this.order.state == server.orderState.已完成) this.currStep = 3;
    }

    storeclick(st: server.store) {
        if (st.value < this.order.count) { this.toastError("当前销售仓油量不足！"); return; }

        this.store = st;
        this.order.storeId = st.id;
        this.order.store = st;
        this.showStores = false;
        this.changeState(server.orderState.装油中);
        console.log(st.id);
    }

    changeState(nextState: server.orderState) {
        if (this.currStep == server.orderState.选择油仓) {
            if (this.order.store == null || this.order.storeId == null) {
                this.toastError("请选择销售仓")
                return;
            }
        }
        this.putState(nextState);
    }

    change(label: string, tabkey: string) {
        console.log(label);

    }

    getOrders(toPage?: number) {
        if (this.page == null) this.page = 1;
        if (toPage != null) this.page = toPage;
        axios.get('/api/Order/GetByIsFinished/' + this.orderType.toString()
            + '?page=' + this.page.toString()
            + '&isFinished=false')
            .then((res) => {
                let jobj = res.data as server.resultJSON<server.order[]>;
                if (jobj.code == 0 && jobj.data.length > 0) {
                    this.orders = jobj.data;
                    this.page++;
                }
                else {
                    this.toastError("没有相关数据");
                    this.showOrders = false;
                }
            });
    }

    getOrder(oid: string, callback: Function) {
        this.$dialog.loading.open("正在加载...请稍后");
        axios.get('/api/Order/' + oid).then((res) => {
            let jobj = res.data as server.resultJSON<server.order>;
            if (jobj.code == 0) {
                if (jobj.data.state == server.orderState.已完成)
                    window.location.href = '/#/sales/order/' + oid + "/load";
                this.$dialog.loading.close();
                this.order = jobj.data;
                this.matchCurrStep();
                callback();
            }
        });
    }

    getStores() {
        axios.get('/api/Store/GetByClass?sc=' + server.storeClass.销售仓.toString()).then((res) => {
            let jobj = res.data as server.resultJSON<server.store[]>;
            if (jobj.code == 0)
                this.stores = jobj.data;
        });
    }

    //获取生产员
    getWorkers() {
        axios.get('/api/User/Worker').then((res) => {
            let jobj = res.data as work.tagMemberResult;
            if (jobj.errcode == 0) {
                this.workers = jobj.userlist;
            }
        });
    }

    putState(state: server.orderState) {
        //console.log(this.order.storeId);
        this.order.state = state;
        this.order.oilCount = this.order.count;
        this.order.oilCountLitre = this.order.count;
        axios.put('/api/Order/ChangeState', this.order).then((res) => {
            let jobj = res.data as server.resultJSON<server.order>;
            if (jobj.code == 0) {
                this.order = jobj.data;
                console.log(this.order);
                this.matchCurrStep();
            }
            else
                this.toastError(jobj.msg);
        });
    }
}