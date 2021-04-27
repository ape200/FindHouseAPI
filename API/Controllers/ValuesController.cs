using API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API.Controllers
{

    namespace API.Controllers
    {
        [Route("api/[controller]")]
        [EnableCors("cors")]//设置跨域处理的代理 3 
        public class ValuesController : Controller
        {

            #region 依赖注入
            public HouseContext db;
            public ValuesController(HouseContext db)
            {
                this.db = db;
            }
            #endregion


            #region 显示(测试方法)
            /// <summary>
            ///测试(显示)
            /// </summary>
            /// <returns></returns>
            [Route("Get")]
            [HttpGet]
            public IEnumerable<House> GetValue()
            {
                return db.Houses.ToList();
            }
            #endregion


            #region 权限管理(相关方法)
            
            /// <summary>
            /// 登录
            /// </summary>
            /// <param name="name"></param>
            /// <param name="pass"></param>
            /// <returns></returns>
            [Route("Login")]
            [HttpGet]
            public async Task<ActionResult<EmployeeInfo>> GetEmpLogin(string name, string pass)
            {
                string newpass = Common.Md5Helper.Get_MD5(pass,"utf-8");
                return await db.EmployeeInfo.AsNoTracking().FirstOrDefaultAsync(e => e.Eno.Equals(name) && e.Password.Equals(newpass));
            }
            /// <summary>
            /// 权限显示
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            [HttpGet]
            [Route("GetMenu/{id}")]
            public async Task<List<MenuInfo>> GetMenu(int id)
            {
                var linq = from m in db.MenuInfo
                           join rm in db.RoleMenu on m.MId equals rm.MId
                           join r in db.RoleInfo on rm.RId equals r.RId
                           join er in db.EmpRole on r.RId equals er.RID
                           join e in db.EmployeeInfo on er.EID equals e.EId
                           where e.EId == id
                           select m;
                return await linq.ToListAsync();
            }

            #endregion



            #region 张怡帆相关模块（后台功能）
            /// <summary>
            /// 首页显示
            /// </summary>
            /// <returns></returns>
            [Route("ShowHotpost")]
            [HttpGet]
            public async Task<ActionResult<IEnumerable<FristPage>>> ShowHotpost()
            {
                var linq = from hpt in db.FristPages
                            select hpt;
                return await linq.ToListAsync();
            }
            /// <summary>
            /// 二手房显示
            /// </summary>
            /// <returns></returns>
            [Route("ShowSeHo")]
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Second_House>>> ShowSeHo()
            {
                var linq = from hpp in db.Second_Houses
                           select hpp;
                return await linq.ToListAsync();
            }

            #endregion



            #region 张梦早用户管理模块(相关方法)

            /// <summary>
            /// 用户登录
            /// </summary>
            /// <param name="Name"></param>
            /// <param name="Password"></param>
            /// <returns></returns>
            [HttpGet]
            [Route("loginuser")]

            public ActionResult loginuser(string Name, string Password)
            {
                //string token = _jwtService.GetToken(Password);
                users users = db.users.FirstOrDefault(u => u.Name == Name && u.Password == Password);
                if (users != null)
                {
                    return Ok(new { status = 200, result = "成功", users = users });
                }
                else
                {
                    return Ok(new { status = 1001, result = "账户或密码错误", emp = "" });
                }
            }
            /// <summary>
            /// 用户列表
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            [Route("show")]
            public ActionResult show()
            {
                //string token = _jwtService.GetToken(Password);
                List<users> users = db.users.ToList();
                if (users != null)
                {
                    return Ok(new { status = 200, result = "成功", users = users });
                }
                else
                {
                    return Ok(new { status = 1001, result = "失败", users = "" });
                }
            }
            /// <summary>
            /// 查询
            /// </summary>
            /// <param name="Name"></param>
            /// <returns></returns>
            [HttpGet]
            [Route("queryuser")]
            public ActionResult queryuser(string Name)
            {

                var list = from u in db.users where u.Name.Contains(Name) select u;
                if (list != null)
                {
                    return Ok(new { status = 200, result = "成功", users = list });
                }
                else
                {
                    return Ok(new { status = 1001, result = "失败", users = "" });
                }
            }
            /// <summary>
            /// 用户关注列表
            /// </summary>
            /// <param name="Gid"></param>
            /// <returns></returns>
            [HttpGet]
            [Route("attentionshow")]
            public ActionResult attentionshow(int Gid)
            {
                var linq = from u in db.users where u.Gid == Gid select u;
                if (linq != null)
                {
                    return Ok(new { status = 200, result = "成功", users = linq });

                }
                else
                {
                    return Ok(new { status = 1001, result = "失败", users = "" });
                }
            }
            /// <summary>
            /// 注册用户
            /// </summary>
            /// <param name="users"></param>
            /// <returns></returns>
            [HttpPost]
            [Route("Adduser")]
            public async Task<ActionResult<int>> Adduser([FromBody] users users)
            {

                db.users.Add(users);
                return await db.SaveChangesAsync();

            }
            /// <summary>
            ///  用户详情
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            [HttpGet]
            [Route("Upid")]
            public ActionResult Upid(int Id)
            {
                users users = db.users.FirstOrDefault(u => u.Id == Id);
                if (users != null)
                {
                    return Ok(new { status = 200, result = "成功", users = users });
                }
                else
                {
                    return Ok(new { status = 1001, result = "失败", users = "" });
                }

            }
            /// <summary>
            /// 修改用户信息
            /// </summary>
            /// <param name="u"></param>
            /// <returns></returns>
            [HttpPut]
            [Route("EditUser")]
            public async Task<ActionResult<int>> EditUser([FromBody] users u)
            {
                db.Entry(u).State = EntityState.Modified;
                return await db.SaveChangesAsync();

            }

            /// <summary>
            /// 删除用户
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            [HttpDelete]
            [Route("DeleteUser")]
            public async Task<ActionResult<int>> DeleteUser(int Id)
            {
                db.users.Remove(db.users.FirstOrDefault(u => u.Id == Id));
                return await db.SaveChangesAsync();

            }

            #endregion

             
            #region 焦梓涵-新房模块


            #region 显示查询新房列表
            /// <summary>
            /// 查询+显示新房列表
            /// </summary>
            /// <param name="condition">查询条件</param>
            /// <returns></returns>
            [HttpGet]
            [Route("NewHomeShow")]
            public async Task<ActionResult<IEnumerable<NewHome>>> NewHomeShow(string condition)
            {
                var showlinq = from Data in db.NewHome select Data;
                if (condition != null)
                {
                    showlinq = (IOrderedQueryable<NewHome>)showlinq.Where(data => data.HomeName.Contains(condition));
                }
                return await showlinq.ToListAsync();
            }
            #endregion

            #region 添加新房
            /// <summary>
            /// 添加新房
            /// </summary>
            /// <param name="homeadd"></param>
            /// <returns></returns>
            [HttpPost]
            [Route("AddNewHome")]
            public async Task<ActionResult<int>> AddNewHome([FromBody] NewHome homeadd)
            {
                db.NewHome.Add(homeadd);
                return await db.SaveChangesAsync();
            }
            #endregion


            #region 查看新房详情
            /// <summary>
            /// 新房详情
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            [Route("GetHomeDetail")]
            public ActionResult GetHomeDetail(int id)
            {
                var home = db.NewHome.FirstOrDefault(h => h.HomeId == id);
                if (home != null)
                {
                    return Ok(new { status = 200, result = "成功", users = home });
                }
                else
                {
                    return Ok(new { status = 1001, result = "失败", users = "" });
                }
            }
            #endregion


            #region 删除新闻列表
            /// <summary>
            /// 删除新闻列表
            /// </summary>
            /// <param name="id">根据id删除</param>
            /// <returns></returns>
            [HttpDelete]
            [Route("DelNewHomeList")]
            public async Task<ActionResult<int>> DelNewHomeList(int id)
            {
                db.NewHome.Remove(db.NewHome.FirstOrDefault(data => data.HomeId == id));
                return await db.SaveChangesAsync();
            }
            #endregion


            #endregion


            #region 李乐楠出租房模块(方法的实现)
            /// <summary>
            /// 出租房显示
            /// </summary>
            /// <returns></returns>
            [Route("retal")]
            [HttpGet]
            public IEnumerable<rental> GetRentals()
            {
                return db.rental.ToList();
            }
            #endregion



        }
    }
}
