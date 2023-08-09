create table registration(id varchar(20),name varchar(20),age int,mobile varchar(20));


----INSERT---

create procedure SPI_reg
@id varchar(20),
@name varchar(20),
@age int,
@mobile varchar(20)
as
	insert into registration(id,name,age,mobile)values(@id,@name,@age,@mobile);
	go
	Exec SPI_reg @id='1',@name='arun',@age='11',@mobile='1111'
	Exec SPI_reg @id='2',@name='varun',@age='22',@mobile='2222'

	select * from registration;

	--UPDATE--
	create procedure SPU_reg
	@id varchar(20),
	@name varchar(20)
	as
	update registration set name=@name where id=@id;
	go
	exec SPU_reg @id='1', @name='sreejith'

	----DELETE---

	create procedure SPD_reg
	@id varchar(20)
	as
	delete from registration where id=@id;
	go
	exec SPD_reg @id='1'

	-----SELECT----
	create procedure SPS_reg
	as
	begin
	select * from registration;
	end
	exec SPS_reg





