﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MFS.Models
{
    public class Store : EntityBase
    {
        public StoreClass StoreClass { get; set; }
        /// <summary>
        /// 容量
        /// </summary>
        public decimal Volume { get; set; }
        /// <summary>
        /// 平均单价成本
        /// </summary>
        public decimal AvgPrice { get; set; }
        /// <summary>
        /// 上次数量
        /// </summary>
        public decimal LastValue { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// 最近测量时间
        /// </summary>
        public DateTime LastSurveyAt { get; set; }
        /// <summary>
        /// 当前价值
        /// </summary>
        public decimal Cost
        {
            get
            {
                return AvgPrice * Value;
            }
        }
        public bool IsUse { get; set; } = true;
        public int StoreTypeId { get; set; }
        public virtual StoreType StoreType { get; set; }
        public decimal SumOutValue { get; set; }
        public decimal SumInValue { get; set; }
    }
    public enum StoreClass
    {
        销售仓,
        存储仓,
        全部
    }
    public class StoreType : EntityBase
    {
        public StoreType()
        {
            if (Stores == null)
                Stores = new List<Store>();
        }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
