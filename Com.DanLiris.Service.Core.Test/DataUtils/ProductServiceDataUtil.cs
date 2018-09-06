﻿using Com.DanLiris.Service.Core.Lib;
using Com.DanLiris.Service.Core.Lib.Models;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.DanLiris.Service.Core.Lib.ViewModels;
using Com.DanLiris.Service.Core.Test.Helpers;
using Com.DanLiris.Service.Core.Test.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Core.Test.DataUtils
{
    public class ProductServiceDataUtil : BasicDataUtil<CoreDbContext, ProductService, Product>, IEmptyData<ProductViewModel>
    {

        public ProductServiceDataUtil(CoreDbContext dbContext, ProductService service) : base(dbContext, service)
        {
        }        

        public ProductViewModel GetEmptyData()
        {
            ProductViewModel Data = new ProductViewModel();

            Data.Name = "";
            Data.Code = "";
            Data.Description = "desc";
            Data.Price = 0;
            Data.Tags = "tags";
            return Data;
        }

        public override Product GetNewData()
        {
            string guid = Guid.NewGuid().ToString();
            Product TestData = new Product
            {
                Code = guid,
                Name = string.Format("TEST {0}", guid),
                ProductionOrderNo = "ProductionOrderNo",
                CurrencySymbol = "curr",
                Active = true,
                BuyerAddress = "buyerAddress",
                BuyerName = "bname",
                BuyerId = 1,
                ColorName = "color",
                Construction = "cons",
                CurrencyCode = "currcode",
                CurrencyId = 1,
                Description = "desc",
                DesignCode = "dcode",
                DesignNumber = "dnum",
                Grade = "grade",
                Length = 0,
                Lot = "lot",
                OrderTypeCode = "otc",
                OrderTypeId = 1,
                OrderTypeName = "otn",
                Price = 0,
                ProductionOrderId = 1,
                Tags = "tags",
                UomId = 1,
                UomUnit = "uom",
                Weight = 0,
                UId = guid
            };

            return TestData;
        }

        public override async Task<Product> GetTestDataAsync()
        {
            Product Data = GetNewData();
            await this.Service.CreateModel(Data);
            return Data;
        }
    }
}