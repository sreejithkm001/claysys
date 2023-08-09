create table customerreg(id int,name varchar(20),place varchar(20),gender varchar(20),birthdate varchar(20));

----TO CREATE SINGLE STORED PROCEDURE----
    create procedure SP_Reg(
		@type as varchar(max),
		@id as int=null,
		@name as varchar(max)=null,
		@place as varchar(max)=null,
		@gender as varchar(max)=null,
		@birthdate as varchar(max)=null)
	as
	begin

		if @type='SP_insert'
		begin
		insert into customerreg
		values(@id,@name,@place,@gender,@birthdate);
		end;

		if @type='SP_update'
		begin
		update	customerreg set name=@name,place=@place,gender=@gender,birthdate=@birthdate where id=@id
		end;

		if @type='SP_select'
		begin
		select * from customerreg
		end;

		if @type='SP_delete'
		begin
		delete from customerreg where id=@id
		end;
	end;

	------INSERT----
	exec SP_Reg @type='SP_insert',@id='101',@name='ram',@place='thrissur',@gender='male',@birthdate='30/10/1999';
	go

	-----UPDATE-----
	exec SP_Reg @type='SP_update',@id='101',@name='ramu',@place='thrissur',@gender='male',@birthdate='30/10/1999';
	go

	----DISPLAY----
	exec SP_Reg @type='SP_select';
	go

	----DELETE----
	exec SP_Reg @type='SP_delete',@id='101';
	go

	