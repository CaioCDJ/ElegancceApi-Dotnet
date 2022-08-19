using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiSalao.ViewModels;
using ApiSalao.Models;

namespace ApiSalao.EndPoints 
{
    public static class UserEndpoints{

        public static void mapUserEndPoints(this WebApplication app){

            /*            
            app.MapGet("/user/", async([FromServices]d37g66beu35psqContext context)=>{
                return await context.Users.ToListAsync();
            });
            */          
            // user by Id
            app.MapGet("/user/{id}", async([FromServices]d37g66beu35psqContext context, 
                [FromRoute]int? id)=>{

                User? user = await context.Users.FirstOrDefaultAsync(x=>
                    x.Id == id);
                
                if(user is not null)
                     return Results.Ok(user);
                else
                    return Results.NotFound();
            });

            app.MapDelete("/user/{id}", async([FromServices]d37g66beu35psqContext context,
                [FromRoute] int id)=>{
                
                    
            } );
        }
    }   
}