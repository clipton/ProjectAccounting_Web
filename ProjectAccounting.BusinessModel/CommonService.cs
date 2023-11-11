using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectAccounting.Models.CustomModels;
using ProjectAccounting.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProjectAccounting.BusinessModel
{
    public class CommonService :  ICommonService
    {
        private readonly ProjectAccountingContext _projectAccountingContext;

        public CommonService(ProjectAccountingContext projectAccountingContext)
        {
            this._projectAccountingContext = projectAccountingContext;
        }
        public List<TblUser> GetUsers()
        { 
            var data = _projectAccountingContext.TblUsers.ToList();
            return data;
        }
        public ResponseModel AddNewUser(TblUser info)
        { 
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblUsers.Add(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
        
            return response;
        }
        public ResponseModel UpdateUser(TblUser info)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                _projectAccountingContext.TblUsers.Update(info);
                _projectAccountingContext.SaveChanges();
                response.Status = true;
                response.Message = "Success";
                //var data = _projectAccountingContext.TblUsers.Where(x => x.Id == info.Id).FirstOrDefault();
                //if (data != null)
                //{
                //    data.UserName = info.UserName;
                //    data.UserCode = info.UserCode;
                //    data.Password = info.Password;
                //    data.UserRoleId = info.UserRoleId;
                //    _projectAccountingContext.TblUsers.Update(data);
                //    _projectAccountingContext.SaveChanges();
                //    response.Status = true;
                //    response.Message = "Success";
                //}
                //else
                //{
                //    response.Status = false;
                //    response.Message = "Does Not Exists";
                //}
                
                return response;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public ResponseModel DeleteUser(TblUser info)
        {

            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblUsers.Where(x => x.Id == info.Id).FirstOrDefault();
                if (data != null)
                {
                    _projectAccountingContext.TblUsers.Remove(data);
                    _projectAccountingContext.SaveChanges();
                    response.Status = true;
                    response.Message = "Success";
                }
                else
                {
                    response.Status = false;
                    response.Message = "Does Not Exists";
                }

                return response;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public TblUser GetUserInfosById(int Id)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                var data = _projectAccountingContext.TblUsers.SingleOrDefault(x => x.Id == Id);
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return data = new TblUser();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public object GetCodeById(string Code)
        {
            try
            {
                ResponseModel response = new ResponseModel();
                //var data = _projectAccountingContext.FromSqlRaw($"sp_GetPatternConfig{Code}").ToString();
                //int data = _projectAccountingContext.Database.ExecuteSqlRaw("EXEC dbo.sp_GetPatternConfig @ConfigType", Code);
                //var ss = _projectAccountingContext.Set<IntReturn>().FromSqlRaw("EXEC dbo.sp_GetPatternConfig @ConfigType", Code).AsEnumerable().First().VoucherNumber;

                //var result = _projectAccountingContext.In.FromSql($"EXEC dbo.sp_GetPatternConfig @ConfigType", Code).AsEnumerable().First().VoucherNumber;
                var result = _projectAccountingContext.sp_GetPatternConfig.FromSqlRaw("sp_GetPatternConfig @ConfigType", Code).AsEnumerable().First().VoucherNumber;
                //var result = _projectAccountingContext.Set<IntReturn>().FromSqlRaw("EXEC dbo.sp_GetPatternConfig @ConfigType", Code).AsEnumerable().First().VoucherNumber;

                //myStore({ 0});

                //myEntities.MyProcedure(orderId).FirstOrDefault();

                //if (Convert.ToString(ss) != null)
                //{
                //    return Convert.ToString(ss);
                //}
                //else
                //{
                //    return null;
                //}
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public string GetCodeByCde(string Code)
        //{
        //DbConnection connection = _projectAccountingContext.Database.GetDbConnection();

        //using (DbCommand cmd = connection.CreateCommand())
        //{

        //    cmd.CommandType = "select dbo.FunctionReturnVarchar(@id)";

        //    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar) { Value = id });

        //    if (connection.State.Equals(ConnectionState.Closed))
        //    {
        //        connection.Open();
        //    }

        //    var value = (string)await cmd.ExecuteScalarAsync();
        //}

        //if (connection.State.Equals(ConnectionState.Open))
        //{
        //    connection.Close();
        //}
        //}
        public sp_GetPatternConfig GetCodeByCode(string Code)
        {
            //var result = _projectAccountingContext.sp_GetPatternConfigs.FromSqlInterpolated($"Execute sp_GetPatternConfig @ConfigType = {Code}").ToListAsync();
            //return result;


            var result = _projectAccountingContext.sp_GetPatternConfigs(Code).AsEnumerable();

            sp_GetPatternConfig ss = (sp_GetPatternConfig)result.FirstOrDefault();

            var jsonStr = JsonSerializer.Serialize(result);
            return ss;
        }
    }
}
