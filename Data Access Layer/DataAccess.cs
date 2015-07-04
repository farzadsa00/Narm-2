using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using Models;

namespace Data_Access_Layer
{
    public class DataAccess
    {
        public readonly static string ConnectionString = "server=(local);initial catalog=FRS;integrated security=true";
        public static SqlConnection Connection = new SqlConnection(ConnectionString);

        public static void InsertCharge(StudentInfo student, double amount)
        {
            SqlCommand sc = new SqlCommand();
            sc.CommandText = "update Account set Balance=Balance+" + amount + " where s#=" + student.StudentNumber;
            try
            {
                sc.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }
        public static void SetAccountState(string active)
        {
            SqlCommand sc = new SqlCommand();
            sc.CommandText = "update Account set AcountState="+active;
            try
            {
                sc.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }
        public static void InsertReservedFood(StudentInfo student,DailyReservedScheduleInfo dailyReservedScheduleInfo
            ,int day)
        {
            if (!((day >= 0 && day < 7) && dailyReservedScheduleInfo.StudentNumber == student.StudentNumber))
                throw new Exception();
            SqlCommand sc = new SqlCommand();
            sc.CommandText = "update DailyReservedSchedule set Day#=" + day + ",BF#=" +
                             dailyReservedScheduleInfo.BreakfastNumber
                             + ",LF#=" + dailyReservedScheduleInfo.LunchNumber + ",DF#=" +
                             dailyReservedScheduleInfo.DinnerNumber + " where s#=" +
                             dailyReservedScheduleInfo.StudentNumber;
            try
            {
                sc.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }
        public static void UpdatePassword(StudentInfo student, string newPassword)
        {
            SqlCommand sc = new SqlCommand();
            sc.CommandText = "update Student set Password='" + newPassword+"' where s#="+student.StudentNumber;
            try
            {
                sc.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }
        public static void InsertFood(FoodInfo food)
        {
            SqlCommand sc = new SqlCommand();
            sc.CommandText = "insert into Food values('" + food.FoodName + "'," + food.FoodNumber + "," + food.Price +
                             ")";
            try
            {
                sc.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception();
            }
        }
        public static void UpdateFoodSchedule(FoodSchedule foodSchedule)
        {
            SqlCommand sc = new SqlCommand();
            for (int j = 0; j < 14; j++)
            {
                sc.CommandText = "update FoodSchedule set meal#=" + (j%2) + ", breakfast=" + foodSchedule.Breakfasts[j] +
                                 ",lunch=" + foodSchedule.Lunches[j] + ",dinner=" + foodSchedule.Dinners[j] +
                                 " where day#=" + (j%7);
                try
                {
                    sc.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new Exception();
                }
            }
        }
        public static StudentInfo GetStudentInfo(string cardNumber)
        {
            Connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Student where s#="+cardNumber, Connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow row = ds.Tables[0].Rows[0];
            object[] rowarray = row.ItemArray;
            Connection.Close();
            return new StudentInfo((int) rowarray[0], (string) rowarray[1], (string) rowarray[2], (string) rowarray[3]
                , (int) rowarray[4], (bool) rowarray[5], (bool) rowarray[6], (string) rowarray[7]);
        }
        public static EmployeeInfo GetEmployeeInfo(string cardNumber)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Employee where e#="+ cardNumber, ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow row = ds.Tables[0].Rows[0];
            object[] rowarray = row.ItemArray;
            return new EmployeeInfo((int)rowarray[0], (string)rowarray[1], (string)rowarray[2], (int)rowarray[3]
                , (string)rowarray[4]);
        }
        public static double GetStudentBalance(string studentNumber)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Account where s#="+studentNumber, ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow row = ds.Tables[0].Rows[0];
            object[] rowarray = row.ItemArray;
            return Double.Parse(rowarray[1].ToString());
        }
        public static string GetBreakfastName(int p0, int meal)
        {
            throw new NotImplementedException();
        }
        public static string GetLunchName(int p0, int meal)
        {
            throw new NotImplementedException();
        }
        public static string GetDinnerName(int p0, int meal)
        {
            throw new NotImplementedException();
        }
        public static double GetFoodPrice(int value)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Food where food#=" + value, ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow row = ds.Tables[0].Rows[0];
            object[] rowarray = row.ItemArray;
            return (double) rowarray[1];
        }
        public static List<int> GetNotActiveAccounts()
        {
            List<int> list = new List<int>();
            SqlDataAdapter da = new SqlDataAdapter("select * from Account where AccountState='notactive'", ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add((int) row.ItemArray[0]);
            }
            return list;
        }

        public static FoodSchedule GetFoodSchedule()
        {
            throw new NotImplementedException();
        }
    }
}
