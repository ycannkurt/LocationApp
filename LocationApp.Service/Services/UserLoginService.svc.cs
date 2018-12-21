﻿using LocationApp.Core.Core;
using LocationApp.Data.Dto;
using LocationApp.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocationApp.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserLoginService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserLoginService.svc or UserLoginService.svc.cs at the Solution Explorer and start debugging.
    public class UserLoginService : IUserLoginService
    {
        private UserLoginLogic userLoginLogic = new UserLoginLogic();

        public string AddUserLogin(int userLoginID, string password, string creationDate, string ipAdress, int userID)
        {
            var result = userLoginLogic.AddUserLogin(new UserLoginDto
            {
                UserLoginID = userLoginID,
                Password = password,
                CreationDate = Convert.ToDateTime(creationDate),
                IpAdress = ipAdress,
                UserID = userID

            });
            return JsonConvert.SerializeObject(result);
        }

        public string DelUserLogin(int userLoginID)
        {
            var result = userLoginLogic.DelUserLogin(userLoginID);
            return JsonConvert.SerializeObject(result);
        }

        public string GetUserLogin(int userLoginID)
        {
            var result = userLoginLogic.GetUserLogin(userLoginID);
            return JsonConvert.SerializeObject(result);
        }

        public string SetUserLogin(int userLoginID, string password, string creationDate, string ipAdress, int userID)
        {
            var result = userLoginLogic.SetUserLogin(new UserLoginDto
            {
                Password = password,
                CreationDate = Convert.ToDateTime(creationDate),
                IpAdress = ipAdress,
                UserLoginID = userLoginID,
                UserID = userID

            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
