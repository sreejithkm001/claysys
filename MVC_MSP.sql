Create procedure AddNewEmpDetails 
(  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Insert into Employee(Name,City,Address) values(@Name,@City,@Address)  
End 

Create Procedure [dbo].[GetEmployees]  
as  
begin  
   select *from Employee  
End

Create procedure [dbo].[UpdateEmpDetails]  
(  
   @EmpId int,  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Update Employee   
   set Name=@Name,  
   City=@City,  
   Address=@Address  
   where Id=@EmpId  
End  

Create procedure [dbo].[DeleteEmpById]  
(  
   @EmpId int  
)  
as   
begin  
   Delete from Employee where Id=@EmpId  
End 