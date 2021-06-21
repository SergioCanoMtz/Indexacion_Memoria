use bloque;

delete from indice where id>1;

select top 1 valores from indice where nombre = 'P1';

select * from indice;

select count(*) from indice where nombre = 'P7';

create procedure total_valores
	@nombre nvarchar(50),
	@valores int output

	as
	begin
		set @valores = (select count(*) from indice where nombre = @nombre);
	end


create procedure recuperar_valores
	@nombre nvarchar(50),
	@valor int output

	as
	begin
		set @valor = (select top 1 valores from indice where nombre = @nombre);
	end

create procedure borrar_primerValor
	@valores int

	as
	begin
		delete from indice where valores = @valores;
	end