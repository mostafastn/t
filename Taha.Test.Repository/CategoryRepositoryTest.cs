﻿using NUnit.Framework;
using System.Linq;
using Taha.Repository;

namespace Taha.Test.Repository
{
    [TestFixture]
    public class CategoryRepositoryTest
    {
        [Test]
        public void GetAll()
        {
            var rep = new CategoryRepository();
            var res = rep.GetAll(orderBy: (t => t.OrderBy(u => u.Periority)));
            Assert.AreEqual(res.succeed ,true);
        }
    }
}
