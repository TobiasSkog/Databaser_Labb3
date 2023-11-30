using Databaser_Labb3.Application.Database.DTO;
using Databaser_Labb3.Application.Database.Model;
using Microsoft.Extensions.Configuration;
using Spectre.Console;
using System.Data;
using System.Data.SqlClient;

namespace Databaser_Labb3.Application.Database.ContactDatabaseMethods
{
    internal class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        public List<KlassModel> GetAllClassesFromDB()
        {
            var klassModelList = new List<KlassModel>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("SP_KLASSER_GET_LIST", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        klassModelList.Add(new KlassModel
                        {
                            KlassId = Convert.ToInt32(reader[0]),
                            KlassNamn = reader[1].ToString()
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                AnsiConsole.WriteException(ex);
                Console.ReadKey();
            }
            return klassModelList;
        }

        public Queue<StudentModel> GetAllStudents(SortOption nameSort, SortOption ascOrDescSort)
        {
            var studentModelList = new Queue<StudentModel>();
            var commandText = GetStudentCommandTextBasedOnSortOptions(nameSort, ascOrDescSort);
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new(commandText, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                studentModelList.Enqueue(new StudentModel
                                {
                                    StudentId = Convert.ToInt32(reader[0]),
                                    StudentFirstName = reader.GetString(reader.GetOrdinal("Förnamn")),
                                    StudentLastName = reader.GetString(reader.GetOrdinal("Efternamn")),
                                    StudentNamn = reader.GetString(reader.GetOrdinal("Förnamn")) + " " + reader.GetString(reader.GetOrdinal("Efternamn")),
                                    StudentSSN = reader[3].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AnsiConsole.WriteException(ex);
                Console.ReadKey();
            }
            return studentModelList;
        }
        private string GetStudentCommandTextBasedOnSortOptions(SortOption nameSort, SortOption ascOrDescSort)
        {
            string ascOrDesc = ascOrDescSort == SortOption.Ascending ? "ASC" : "DESC";
            string nameOrder = nameSort == SortOption.ByFirstName ? "Förnamn" : "Efternamn";
            return @$"
                        SELECT StudentId,
                        SUBSTRING(StudentNamn, 1, CHARINDEX(' ', StudentNamn) - 1) AS Förnamn,     
                        SUBSTRING(StudentNamn,
                                     CHARINDEX(' ', StudentNamn) + 1,
                                     LEN(StudentNamn) - CHARINDEX(' ', StudentNamn)) AS Efternamn,
                        StudentSSN
                        FROM Studenter
                        ORDER BY {nameOrder} {ascOrDesc};";
        }

        public List<PersonalModel> GetAllPersonalFromDB()
        {
            var personalModelList = new List<PersonalModel>();
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(_connectionString))
            //    {
            //        SqlCommand command = new SqlCommand("SP_KLASSER_GET_LIST", connection);
            //        command.CommandType = CommandType.StoredProcedure;
            //        connection.Open();
            //        SqlDataReader reader = command.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            personalModelList.Add(new KlassModel
            //            {
            //                KlassId = Convert.ToInt32(reader[0]),
            //                KlassNamn = reader[1].ToString()
            //            });
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    AnsiConsole.WriteException(ex);
            //}
            return personalModelList;
        }

        public List<StudentModel> GetAllStudentsInClass(string className)
        {
            var studentModelList = new List<StudentModel>();


            return studentModelList;
        }
    }
}
