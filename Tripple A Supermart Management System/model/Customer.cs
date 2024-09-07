﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_A_Supermart_Management_System.model
{


    class Customer
    {
        protected string customerId { get; set; }
        protected string customerName { get; set; }
        protected DateTime DoB { get; set; }
        protected string Gender { get; set; }
        protected string Email { get; set; }
        protected string City { get; set; }
        protected string Street { get; set; }
        protected int PostalCode { get; set; }
        protected string mobile { get; set; }
        protected string Type { get; set; }
        protected string MemberStatus { get; set; }


        public virtual DataTable viewNormalCustomer(string mobile,string Type)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {


                string query_select = "select * from Customer where mobile = @mobile and Type = @Type";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    con.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                    }
                }
            }
        }
        public virtual DataTable viewLoyaltyCustomer(string mobile, string Type)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {


                string query_select = "select * from Customer where mobile = @mobile and Type = @Type";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    con.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                    }
                }
            }
        }
    }


    class LoyaltyCustomer : Customer
    {


    }
    class NormalCustomer : Customer
    {
        public override DataTable viewNormalCustomer(string mobile,string Type)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {


                string query_select = "select * from Customer where mobile = @mobile and Type = @Type";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@Type",Type);
                    con.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                    }
                }
            }
        }
        public virtual DataTable viewLoyaltyCustomer(string mobile, string Type)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {


                string query_select = "select * from Customer where mobile = @mobile and Type = @Type";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    con.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                    }
                }
            }
        }
    }
}

