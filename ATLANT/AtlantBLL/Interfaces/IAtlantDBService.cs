﻿using System;
using System.Collections.Generic;
using System.Linq;
using AtlantBLL.Models;

namespace AtlantBLL.Interfaces
{
    public interface IAtlantDBService
    {
        int GetDetailsAmount(Stockmen stockmen);
        IEnumerable<Stockmen> GetStockmens();
        IEnumerable<Detail> GetDetails();
        void InsertStockmen(Stockmen st);
        void InsertDetail(Detail detail);
        void DeleteDetail(int id);
        void DeleteStockmen(int id);
        void Dispose();
    }
}
