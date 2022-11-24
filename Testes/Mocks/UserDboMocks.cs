using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter.people.central.Tests.Mocks
{
    public static class UserDboMocks
    {
        public static UserDBO GetUserDboMock()
        {
            var userDboMock = new UserDBO()
            {
                Id = 124,
                Bi = "BI00006",
                Email = "teste@bancointer.com.br",
                Nome = "Fulano de Tal",
                Situacao = "A",
                DataCriacao = DateTime.Parse("2022-06-20 00:00:00"),
                DataModificacao = DateTime.Parse("2022-06-20 00:00:00")
            };
            return userDboMock; 
        }

        public static List<UserDBO> GetListUserDboMock()
        {
            var userDboMock = new UserDBO()
            {
                Id = 124,
                Bi = "BI00006",
                Email = "teste@bancointer.com.br",
                Nome = "Fulano de Tal",
                Situacao = "A",
                DataCriacao = DateTime.Parse("2022-06-20 00:00:00"),
                DataModificacao = DateTime.Parse("2022-06-20 00:00:00")
            };

            var listUserDbo = new List<UserDBO>();
            listUserDbo.Add(userDboMock);   
            return listUserDbo;
        }

        public static List<UserDBO> GetEmptyListUserDboMock()
        {
            var userDboMock = new UserDBO();
            
            var listUserDbo = new List<UserDBO>();
            listUserDbo.Add(userDboMock);
            return listUserDbo;
        }
    }
}
