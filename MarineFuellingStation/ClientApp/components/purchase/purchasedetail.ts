import ComponentBase from "../../componentbase";
import { Component } from 'vue-property-decorator';
import axios from "axios";
import moment from "moment";

@Component
export default class PurchaseDetailComponent extends ComponentBase {
    model: server.purchase;

    constructor() {
        super();

        this.model = (new Object()) as server.purchase;
    }

    formatDate(d: Date) {
        return moment(d).format("YYYY-MM-DD");
    }

    mounted() {
        let id = this.$route.params.id;
        this.getPurchase(id, () => {
            //设置返回键的连接
            this.$emit('setTitle', this.model.name + ' 采购单明细', '/purchase/purchase');
        });
    }
    
    getPurchase(id: string, callback: Function) {
        axios.get('/api/Purchase/GetDetail/' + id).then((res) => {
            let jobj = res.data as server.resultJSON<server.purchase>;
            if (jobj.code == 0) {
                this.model = jobj.data;
                callback();
            }
        });
    }
}