//using GameStore.DAL.Entities;
//using Microsoft.AspNetCore.Identity;
//using System;
//using Microsoft.Extensions.Options;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;
//using Microsoft.Extensions.Logging;

//namespace GameStore.BLL.Models.BusinessModels
//{
//    public class GameStoreUserManager : UserManager<User>
//    {

//        public GameStoreUserManager(IUserStore<User> store, IOptions<IdentityOptions> options,
//            IPasswordHasher<User> hasher, IEnumerable<IUserValidator<User>> validators,
//            IEnumerable<IPasswordValidator<User>> passwords, ILookupNormalizer keyNormaliser,
//            IdentityErrorDescriber errors, IServiceProvider services,
//            ILogger<UserManager<User>> logger)
//            : base(store, options, hasher, validators, passwords, keyNormaliser, errors, services
//                  , logger)
//        {
//        }
//    }
//}
