﻿using Model.data;
using StubContext;
using StubLib;
using Tarot2B2Model;

namespace UT_Model.Manager;

public class DataManagers
{
    public static readonly ILoader[] Loaders = {
        new Stub(),
        new DbLoader(typeof(TarotDbContextStub), "DataSource=:memory:")
    };
	
    public static readonly ISaver[] Savers = {
        new DbSaver(typeof(TarotDbContextStub), "DataSource=:memory:")
    };
}