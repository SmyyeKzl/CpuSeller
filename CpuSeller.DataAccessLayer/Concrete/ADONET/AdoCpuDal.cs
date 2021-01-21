using CpuSeller.DataAccessLayer.Abstract;
using CpuSeller.DataAccessLayer.Concrete.EntityFramework;
using CpuSeller.Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CpuSeller.DataAccessLayer.Concrete.ADONET
{
    public class AdoCpuDal : ICpuDal
       
    {
        public void Add(Cpu entity)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Cpus (Model,Family,Price) VALUES (@Model,@Family,@Price)"))
            {
                command.Parameters.AddWithValue("Model", entity.Model);
                command.Parameters.AddWithValue("Family", entity.Family);
                command.Parameters.AddWithValue("Price", entity.Price);

                DBMS.ExecuteNonQuery(command);
            }
        }

        public void Delete(Cpu entity)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Cpus WHERE CpuId = @CpuId"))
            {
                command.Parameters.AddWithValue("CpuId", entity.CpuId);
                DBMS.ExecuteNonQuery(command);
            }

        }

        public Cpu Get(Expression<Func<Cpu, bool>> filter)
        {
            var cpuList = new List<Cpu>();
            SqlConnection connection = new SqlConnection(DBMS.Connection);
            SqlCommand command = new SqlCommand("SELECT * FROM Cpus", connection);
            command.Connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var cpu = new Cpu();
                cpu.CpuId = Convert.ToInt32(reader[0]);
                cpu.Model = reader[2].ToString();
                cpu.Family = reader[1].ToString();
                cpu.Price = Convert.ToDecimal(reader[3].ToString());

                cpuList.Add(cpu);
            }

            var list = cpuList.Where(filter.Compile()).ToList();
            command.Connection.Close();
            return list[0];

        }

        public List<Cpu> GetAll(Expression<Func<Cpu, bool>> filter = null)
        {
            var cpuList = new List<Cpu>();
            SqlConnection connection = new SqlConnection(DBMS.Connection);
            SqlCommand command = new SqlCommand("SELECT * FROM Cpus", connection);
            command.Connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var cpu = new Cpu();
                cpu.CpuId = Convert.ToInt32(reader[0]);
                cpu.Model = reader[2].ToString();
                cpu.Family = reader[1].ToString();
                cpu.Price = Convert.ToDecimal(reader[3].ToString());

                cpuList.Add(cpu);
            }

           
            command.Connection.Close();
            return filter == null ? cpuList : cpuList.Where(filter.Compile()).ToList();
        }

        public void Update(Cpu entity)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Cpus SET Model = @ Model, Family=@Family, Price=@Price WHERE CpuId = @CpuId"))
            {
                command.Parameters.AddWithValue("CpuId", entity.CpuId);
                command.Parameters.AddWithValue("Family", entity.Family);
                command.Parameters.AddWithValue(" Model", entity.Model);
                command.Parameters.AddWithValue("Price", entity.Price);
                DBMS.ExecuteNonQuery(command);
            }

        }
    }
}
