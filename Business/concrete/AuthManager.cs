using Business.Abstract;
using Business.Contans;
using Core.Entities.Concrete;
using Core.Utilities.Result;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.CarDTOs;
using Entities.Concrete;

namespace Business.concrete
{
    public class AuthManager : IAuthService
    {
        private IUserCoreService _userCoreService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserCoreService userCoreService, ITokenHelper tokenHelper)
        {
            _userCoreService = userCoreService;
            _tokenHelper = tokenHelper;
        }

       
        

        public IDataResult<UserCore> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new UserCore
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userCoreService.Add(user);
            return new SuccessDataResult<UserCore>(user, Messages.UserRegistered);
        }

        public IDataResult<UserCore> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userCoreService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<UserCore>("Kullanici bulunamadi.");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<UserCore>("Parola hatasi");
            }

            return new SuccessDataResult<UserCore>(userToCheck, "Basarili giris");
        }

        public IResult UserExists(string email)
        {
            if (_userCoreService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(UserCore user)
        {
            var claims = _userCoreService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
