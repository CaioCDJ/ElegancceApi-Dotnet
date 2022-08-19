using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ApiSalao.Models;

namespace ApiSalao.EndPoints
{
   public class logs{
        public string email{get;set;}
        public String password{get;set;}
    }
    public static class LoginEnpoints{

        public static void mapLoginEndPoints(this WebApplication app){

            app.MapGet("/login", async(d37g66beu35psqContext context, [FromBody] logs logar) => {

                if(logar is null)
                    return Results.BadRequest();

                try
                {
                    User user = await context.Users.FirstOrDefaultAsync(x=>
                     x.Email == logar.email   && x.Password == logar.password);

                    if(user is not null){
                        return Results.Ok("User");
                    }

                    Adm adm = await context.Adms.FirstOrDefaultAsync(x=>
                        x.Email == logar.email && x.Password == logar.password);

                   if(adm is not null)
                        return Results.Ok("Admin");
                
                    return Results.NotFound();
                }
                catch (Exception e)
                {
                    return Results.BadRequest();    
                }                

             }
            );
        }
    }
    
}