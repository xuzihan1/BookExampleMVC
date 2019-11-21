using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookExamples.Areas.Chapter08.Models.MyDb2Model;

namespace BookExamples.Areas.Chapter08.cs
{
    public class MyDb2Init : DropCreateDatabaseIfModelChanges<MyDb2>
    {
        protected override void Seed(MyDb2 context)
        {
            base.Seed(context);
        }
    }
}