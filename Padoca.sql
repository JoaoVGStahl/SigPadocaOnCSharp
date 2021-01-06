
USE [master]
GO
/****** Object:  Database [padoca]    Script Date: 26/10/2020 11:09:44 ******/
CREATE DATABASE [padoca]
GO

USE [padoca]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 26/10/2020 11:09:44 ******/

CREATE TABLE Clientes(
	[cpfClientes] [decimal](11, 0) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[datanasc] [date] NOT NULL,
	[sexo] [char](1) NULL,
	[rg] [varchar](14) NOT NULL,
	[celular] [varchar](14) NOT NULL,
	[email] [varchar](60) NULL,
	[endereco] [varchar](70) NULL,
	[bairro] [varchar](20) NULL,
	[cidade] [varchar](25) NULL,
	[estado] [char](2) NULL,
	PRIMARY KEY(cpfClientes)
)
GO
CREATE TABLE Fornecedores(
	[cnpj] [decimal](14, 0) NOT NULL,
	[razaoSocial] [varchar](50) NOT NULL,
	[inscEstadual] [decimal](12, 0) NOT NULL,
	[endereco] [varchar](60) NULL,
	[bairro] [varchar](20) NULL,
	[cidade] [varchar](30) NOT NULL,
	[estado] [char](2) NOT NULL,
	[telefone] [varchar](20) NOT NULL,
	[email] [varchar](50) NULL,
	[site] [varchar](80) NULL,
	PRIMARY KEY(cnpj)
)
GO

CREATE TABLE Produtos(
	[idProduto] [int] identity(1,1) NOT NULL,
	[descricao] [varchar](50) NULL,
	[unidade] [char](3) NULL,
	[ncm] [int] NULL,
	[undEstoque] [int] NULL,
	[categoria] [varchar](20) NULL,
	[precoUnitario] [numeric](10, 2) NULL,
	[cnpjFornece] [decimal](14, 0) NULL,
	PRIMARY KEY(idProduto),
	FOREIGN KEY(cnpjFornece) REFERENCES Fornecedores(cnpj)
)
GO

CREATE TABLE Pedidos(
	[idPedido] [int] identity(1,1) NOT NULL,
	[dataPedido] [date] NULL,
	[horaPedido] [time](7) NULL,
	[valorPedido] [numeric](12, 2) NULL,
	[cpfClientes] [decimal](11, 0) NOT NULL,
	PRIMARY KEY(idPedido),
	FOREIGN KEY(cpfClientes) REFERENCES Clientes(cpfClientes)
)
GO

CREATE TABLE ItensPedido(
	[idItensPedido] [int] identity(1,1) NOT NULL,
	[quantItens] [int] NOT NULL,
	[idPedido] [int] NOT NULL,
	[idProduto] [int] NOT NULL,
	[precoVenda] [numeric](12, 2) NOT NULL,
	PRIMARY KEY(idItensPedido),
	FOREIGN KEY(idPedido) REFERENCES Pedidos(idPedido),
	FOREIGN KEY(idProduto) REFERENCES Produtos(idProduto),
)
GO

CREATE TABLE [dbo].[NotaFiscal](
	[idNotaFiscal] [int] identity(1,1) NOT NULL,
	[datEmissao] [date] NOT NULL,
	[horaEmissao] [time](7) NOT NULL,
	[idPedido] [int] NOT NULL,
	[valorNotaFiscal] [numeric](14, 2) NOT NULL,
	PRIMARY KEY(idNotaFiscal),
	FOREIGN KEY(idPedido) REFERENCES Pedidos(idPedido)
)
GO

