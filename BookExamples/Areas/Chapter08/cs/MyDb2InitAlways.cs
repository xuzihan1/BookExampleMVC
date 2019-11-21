﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookExamples.Areas.Chapter08.Models.MyDb2Model;

namespace BookExamples.Areas.Chapter08.cs
{
    public class MyDb2InitAlways : DropCreateDatabaseAlways<MyDb2>
    {
        protected override void Seed(MyDb2 context)
        {
            var t1 = new List<MyTable1>
            {
                new MyTable1 {KeChengID = "001", KeChengName = "数据结构"},
                new MyTable1 {KeChengID = "002", KeChengName = "操作系统"},
                new MyTable1 {KeChengID = "003", KeChengName = "计算机组成原理"},
                new MyTable1 {KeChengID = "004", KeChengName = "c#程序设计"},
            };
            t1.ForEach(v => context.MyTable1.Add(v));
            context.SaveChanges();
            var t2 = new List<MyTable2>
            {
                new MyTable2 {StudentID = "15001001", StudentName = "张三玉",RuXueShiJian = DateTime.Parse("2019-11-21")},
                new MyTable2 {StudentID = "15001002", StudentName = "李思文",RuXueShiJian = DateTime.Parse("2019-11-21")},
                new MyTable2 {StudentID = "15001003", StudentName = "王五行",RuXueShiJian = DateTime.Parse("2019-11-21")},
                new MyTable2 {StudentID = "15001004", StudentName = "赵六方",RuXueShiJian = DateTime.Parse("2019-11-21")},

            };
            t2.ForEach(v => context.MyTable2.Add(v));
            context.SaveChanges();
            var t3 = new List<MyTable3>
            {
                new MyTable3 {StudentID = "15001001", KeChengID = "001",Grade = 80},
                new MyTable3 {StudentID = "15001003", KeChengID = "001",Grade = 81},
                new MyTable3 {StudentID = "15001003", KeChengID = "001",Grade = 82},
                new MyTable3 {StudentID = "15001004", KeChengID = "001",Grade = 83},
                new MyTable3 {StudentID = "15001001", KeChengID = "002",Grade = 90},
                new MyTable3 {StudentID = "15001003", KeChengID = "002",Grade = 91},
                new MyTable3 {StudentID = "15001003", KeChengID = "002",Grade = 92},
                new MyTable3 {StudentID = "15001004", KeChengID = "002",Grade = 93},
            };
            t3.ForEach(v => context.MyTable3.Add(v));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}