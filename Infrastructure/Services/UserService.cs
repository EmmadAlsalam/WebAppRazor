using Infrastructure.Entites;
using Infrastructure.Factories;
using Infrastructure.Helpers;
using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.VisualBasic;

namespace Infrastructure.Services;

public class UserService(UserRepository repository, AddressService addressService)
{
    private readonly UserRepository _repository = repository;
    private readonly AddressService _addressService = addressService;

    public async Task<ResponseResult> CreateUserAsunc(SignUpModel model)
    {
        try
        {
            var exists = await _repository.AlreadyExistssync(x => x.Email == model.Email);
            if (exists.StatusCode!= StatusCode.EXISTS)
                return exists;

            var result = await _repository.CreateOneAsync(UserFactory.Create(model));
                if (result.StatusCode != StatusCode.OK)

                    return result;
                return ResponseFactory.Ok("User was created succesfully");

        }

        catch (Exception ex ) { return ResponseFactory.Error(ex.Message); }
    }



    public async Task<ResponseResult> SignInUserAsunc(SignInModel model)
    {
        try
        {
            var result = await _repository.AlreadyExistssync(x => x.Email == model.Email);
            if (result.StatusCode == StatusCode.OK && result.ContentResult != null)
            {
                var userEntity = (UserEntity)result.ContentResult;
                if (PasswordHasher.ValidateSecurePassword(model.Password, userEntity.Password, userEntity.SecurityKry))
                    return ResponseFactory.Ok();


            }
          
                return ResponseFactory.Error("Incorrect email or password");

        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }

}
