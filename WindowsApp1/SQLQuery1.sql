-- =========================================================
-- 1. CRIAÇÃO DO BANCO DE DADOS
-- =========================================================
CREATE DATABASE db_golden_moment;
GO

USE db_golden_moment;
GO

-- =========================================================
-- 2. TABELA DE FUNCIONÁRIOS / USUÁRIOS (Módulo de Segurança)
-- =========================================================
CREATE TABLE tb_funcionarios (
    id_funcionario INT PRIMARY KEY IDENTITY(1,1),
    nome_completo VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) UNIQUE NOT NULL,
    data_nascimento DATE,
    whatsapp VARCHAR(20),
    email VARCHAR(100) NOT NULL,
    cep VARCHAR(10),
    endereco VARCHAR(150),
    numero VARCHAR(20),
    bairro VARCHAR(50),
    cidade VARCHAR(50),
    complemento VARCHAR(100),
    
    -- Dados Operacionais e de Login
    cargo VARCHAR(50),
    perfil_acesso VARCHAR(20) NOT NULL, -- Administrador ou Operador
    usuario VARCHAR(50) UNIQUE NOT NULL,
    senha VARCHAR(100) NOT NULL,
    status_conta VARCHAR(20) DEFAULT 'Ativo', -- Ativo, Bloqueado, Excluído
    foto VARBINARY(MAX) -- Armazena a imagem do PictureBox
);
GO

-- Inserindo o Administrador Master exigido pela documentação
INSERT INTO tb_funcionarios (nome_completo, cpf, email, perfil_acesso, usuario, senha, status_conta)
VALUES ('Administrador do Sistema', '000.000.000-00', 'admin@goldenmoment.com', 'Administrador', 'admin', 'admin', 'Ativo');
GO

-- =========================================================
-- 3. TABELA DE CLIENTES (Módulo de CRM)
-- =========================================================
CREATE TABLE tb_clientes (
    id_cliente INT PRIMARY KEY IDENTITY(1,1),
    nome_completo VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) UNIQUE NOT NULL,
    data_nascimento DATE,
    whatsapp VARCHAR(20),
    email VARCHAR(100),
    cep VARCHAR(10),
    endereco VARCHAR(150),
    numero VARCHAR(20),
    bairro VARCHAR(50),
    cidade VARCHAR(50),
    complemento VARCHAR(100),
    observacoes VARCHAR(MAX)
);
GO

-- =========================================================
-- 4. TABELAS DO CATÁLOGO (Produtos, Serviços e Pacotes)
-- =========================================================
CREATE TABLE tb_catalogo (
    id_item INT PRIMARY KEY IDENTITY(1,1),
    nome_item VARCHAR(100) NOT NULL,
    tipo_item VARCHAR(50) NOT NULL, -- 'Pacote Base' ou 'Item/Serviço Extra'
    categoria VARCHAR(50), -- Nulo se for Pacote
    valor_base DECIMAL(10,2) NOT NULL,
    descricao_detalhada VARCHAR(MAX),
    status_item BIT DEFAULT 1 -- 1 = Ativo, 0 = Inativo
);
GO

-- a melhor prática é ter uma tabela separada (Relação 1 para Muitos)
CREATE TABLE tb_imagens_catalogo (
    id_imagem INT PRIMARY KEY IDENTITY(1,1),
    id_item INT NOT NULL,
    imagem VARBINARY(MAX) NOT NULL,
    FOREIGN KEY (id_item) REFERENCES tb_catalogo(id_item)
);
GO

-- =========================================================
-- 5. TABELAS DE VENDAS E EVENTOS (O Coração do Sistema)
-- =========================================================
-- A "Capa" do Contrato (Aba 1 e Aba 3 do seu sistema)
CREATE TABLE tb_eventos (
    id_evento INT PRIMARY KEY IDENTITY(1,1),
    id_cliente INT NOT NULL,
    id_funcionario INT NOT NULL, -- Quem fez a venda
    
    -- Dados da Aba 1 (Calendário)
    data_evento DATE NOT NULL,
    horario_inicio VARCHAR(10),
    horario_fim VARCHAR(10),
    
    -- Dados da Aba 2 (Pacote Principal)
    id_pacote_base INT NOT NULL, 
    
    -- Dados da Aba 3 (Financeiro)
    subtotal_pacote DECIMAL(10,2) NOT NULL,
    subtotal_extras DECIMAL(10,2) DEFAULT 0.00,
    desconto DECIMAL(10,2) DEFAULT 0.00,
    valor_total DECIMAL(10,2) NOT NULL,
    forma_pagamento VARCHAR(50) NOT NULL,
    qtd_parcelas INT DEFAULT 1,
    status_contrato VARCHAR(50) DEFAULT 'Fechado',
    data_emissao DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id_cliente),
    FOREIGN KEY (id_funcionario) REFERENCES tb_funcionarios(id_funcionario),
    FOREIGN KEY (id_pacote_base) REFERENCES tb_catalogo(id_item)
);
GO

-- O "Carrinho" (Itens Adicionais e Serviços da Aba 2)
CREATE TABLE tb_eventos_extras (
    id_evento_extra INT PRIMARY KEY IDENTITY(1,1),
    id_evento INT NOT NULL,
    id_item INT NOT NULL, -- O serviço/produto extra escolhido
    quantidade INT NOT NULL,
    valor_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

    FOREIGN KEY (id_evento) REFERENCES tb_eventos(id_evento),
    FOREIGN KEY (id_item) REFERENCES tb_catalogo(id_item)
);
GO

USE db_golden_moment; -- Garante que você está no banco certo
GO

SELECT COUNT(*) AS total_eventos 
FROM tb_eventos 
WHERE MONTH(data_evento) = 6 AND YEAR(data_evento) = 2026;
GO


