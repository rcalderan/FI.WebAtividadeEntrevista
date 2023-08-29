CREATE PROC FI_SP_AltBeneficiario
	@Id           BIGINT,
    @CPF           VARCHAR (11)  ,
    @NOME          VARCHAR (50) ,	
	@IDCLIENTE           BIGINT
AS
BEGIN
	UPDATE BENEFICIARIOS 
	SET 
		NOME = @NOME, 
		CPF = @CPF,
		IDCLIENTE = @IDCLIENTE
	WHERE Id = @Id
END