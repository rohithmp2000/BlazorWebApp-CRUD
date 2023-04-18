using BlazorWebAppCRUD.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppCRUD.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDBContext applicationDb_Context;
        public EmployeeService(ApplicationDBContext applicationDbContext) 
        {
            applicationDb_Context = applicationDbContext;   
        }

        //Add New
        public async Task<bool>Create(Employee employee)
        {
            await applicationDb_Context.Employees.AddAsync(employee);
            await applicationDb_Context.SaveChangesAsync();
            return true;
        }

        //Read all
        public async Task<List<Employee>> Readall()
        {
            return await applicationDb_Context.Employees.ToListAsync();
        } 

        //Read by id
        public async Task<Employee> Readbyid(int id)
        {
            Employee employee = await applicationDb_Context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return employee;
        }

        //Upadate by id
        public async Task<bool> Update(Employee employee)
        {
            applicationDb_Context.Employees.Update(employee);
            await applicationDb_Context.SaveChangesAsync();
            return true;
        }

        //Delete
        public async Task<bool> Delete(Employee employee)
        {
            applicationDb_Context.Employees.Remove(employee);
            await applicationDb_Context.SaveChangesAsync();
            return true;
        }
    }
}
