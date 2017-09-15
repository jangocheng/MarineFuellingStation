﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MFS.Models
{
    /// <summary>
    /// 采购计划
    /// </summary>
    public class Purchase : EntityBase
    {
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        /// <summary>
        /// 始发地
        /// </summary>
        public string Origin { get; set; }
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 预计到达时间
        /// </summary>
        public DateTime? ArrivalTime { get; set; }
        public string CarNo { get; set; }
        /// <summary>
        /// 挂车号
        /// </summary>
        public string TrailerNo { get; set; }
        public string Driver1 { get; set; }
        public string IdCard1 { get; set; }
        public string Phone1 { get; set; }
        public string Driver2 { get; set; }
        public string IdCard2 { get; set; }
        public string Phone2 { get; set; }

        //陆上卸油用到的字段

        /// <summary>
        /// 油车磅秤数
        /// </summary>
        public float ScaleWithCar { get; set; } = 0;

        /// <summary>
        /// 油车磅秤图片地址
        /// </summary>
        public string ScaleWithCarPic { get; set; }

        /// <summary>
        /// 空车磅秤数
        /// </summary>
        public float Scale { get; set; } = 0;

        /// <summary>
        /// 油车磅秤图片地址
        /// </summary>
        public string ScalePic { get; set; }

        /// <summary>
        /// 化验单
        /// </summary>
        [ForeignKey("AssayId")]
        public virtual Assay Assay { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public UnloadState State { get; set; } = UnloadState.已开单;

        public enum UnloadState
        {
            已开单,
            已到达,
            油车过磅,
            化验,
            卸油中,
            空车过磅,
            完工,
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal TotalMoney
        {
            get
            {
                return Price * Count;
            }
        }
    }
}