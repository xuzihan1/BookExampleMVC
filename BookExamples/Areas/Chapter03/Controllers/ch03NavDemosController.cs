using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookExamples.Areas.Chapter03.Models;

namespace BookExamples.Areas.Chapter03.Controllers
{
    public class ch03NavDemosController : Controller
    {
        // GET: Chapter03/ch03NavDemos
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ModelDemo1()
        {
            List<string> list = new List<string>
            {
                "red,红色","green,绿色","blue,蓝色"
            };
            return PartialView(list);
        }
        public ActionResult ModelDemo2()
        {
            MyColorModel myColor = new MyColorModel{EnglishName = "red",ChineseName = "红色"};
            return PartialView(myColor);
        }

        public ActionResult ModelDemo3()
        {
            List<MyStudentModel> students = new List<MyStudentModel>
            {
                new MyStudentModel{XueHao="001",XingMing="张三",XingBie="男",NianLing=20},
                new MyStudentModel{XueHao="002",XingMing="李四",XingBie="男",NianLing=23},
                new MyStudentModel{XueHao="003",XingMing="王五",XingBie="男",NianLing=21},
            };
            return PartialView(students);
        }

        public ActionResult Example9(MyStudentModel student)
        {
            if (Request.HttpMethod=="GET")
            {
                student = new MyStudentModel
                {
                    XueHao = "001",XingMing = "张三",XingBie = "男",NianLing = 20
                };
                return PartialView(student);
            }
            else
            {
                string s = "输入信息有错！";
                if (ModelState.IsValid)
                {
                    s = string.Format
                    (
                        "提交结果：学号：{0}，姓名：{1}，性别：{2}，年龄：{3}",
                        student.XueHao, student.XingMing,student.XingBie,student.NianLing);
                }

                return JavaScript(string.Format("alert('{0}')", s));
            }
        }

        public ActionResult Validation1(MyStudentModel student)
        {
            if (Request.HttpMethod == "GET")
            {
                student = new MyStudentModel
                {
                    XueHao = "001",
                    XingMing = "张三",
                    XingBie = "男",
                    NianLing = 20
                };
                return PartialView(student);
            }
            else
            {
                return JavaScript("alert('数据已提交！')");
            }
        }

        public ActionResult Validation2(MyUserModel user)
        {
            if (Request.HttpMethod == "GET")
            {
                user = new MyUserModel();
            }
            else
            {
                if (this.ModelState.IsValid)
                {
                    string s = "服务器验证成功！提交结果：";
                    s += string.Format(
                        "用户Id：{0}，用户名：{1}，年龄：{2}，出生日期：{3}",
                        user.UserId, user.UserName, user.Age, user.BirthDate);
                    ViewBag.Result = s;
                }
            }
            return PartialView(user);
        }
    }
}