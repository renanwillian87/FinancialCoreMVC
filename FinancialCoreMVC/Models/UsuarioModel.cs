using System;
using System.Data;
using FinancialCoreMVC.Util;

namespace FinancialCoreMVC.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Data_Nascimento { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"SELECT ID, Nome, Data_Nascimento FROM USUARIO WHERE EMAIL='{Email}' AND SENHA='{Senha}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            
            if(dt != null)
            {
                if(dt.Rows.Count == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}