using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ApiSalao.ViewModels;
using ApiSalao.Models;

namespace ApiSalao.EndPoints
{

   public static class RegisterUserEndoPoints{

        public static void MapRegisterUserEndPoints(this WebApplication app){
                
            app.MapGet("/Register", async([FromServices]d37g66beu35psqContext context, 
                [FromBody]UserModel newUser)=>{
        
                if(newUser.email is null ||
                    newUser.name is null ||
                    newUser.password is null)
                    return Results.BadRequest();

                try
                {
                    await context.Users.AddAsync(
                        new User(){
                            Name = newUser.name,
                            Email = newUser.email,
                            Password = newUser.password,
                            Phone = newUser.Phone
                        }
                    );
                     await context.SaveChangesAsync();
                    return Results.Ok("Usuario Cadastrado");
                }
                catch (Exception e)
                {
                    return Results.BadRequest(e.Message);    
                } 
            }); 
        }

    } 
}
