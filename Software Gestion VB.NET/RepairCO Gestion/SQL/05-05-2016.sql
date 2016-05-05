/*
Navicat PGSQL Data Transfer

Source Server         : RepairCo
Source Server Version : 90502
Source Host           : 192.168.0.2:5432
Source Database       : repairco
Source Schema         : public

Target Server Type    : PGSQL
Target Server Version : 90502
File Encoding         : 65001

Date: 2016-05-05 16:22:38
*/


-- ----------------------------
-- Sequence structure for clientes_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."clientes_id_seq";
CREATE SEQUENCE "public"."clientes_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

-- ----------------------------
-- Sequence structure for equipo_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."equipo_id_seq";
CREATE SEQUENCE "public"."equipo_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

-- ----------------------------
-- Sequence structure for ot_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ot_id_seq";
CREATE SEQUENCE "public"."ot_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

-- ----------------------------
-- Sequence structure for personal_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."personal_id_seq";
CREATE SEQUENCE "public"."personal_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 4
 CACHE 1;
SELECT setval('"public"."personal_id_seq"', 4, true);

-- ----------------------------
-- Table structure for cargos
-- ----------------------------
DROP TABLE IF EXISTS "public"."cargos";
CREATE TABLE "public"."cargos"()
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of cargos
-- ----------------------------

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS "public"."clientes";
CREATE TABLE "public"."clientes" (
"id" int8 DEFAULT nextval('clientes_id_seq'::regclass) NOT NULL,
"nombre" varchar(100) COLLATE "default",
"Nombre contacto " varchar(100) COLLATE "default",
"Número de teléfono " int8,
"Apellido contacto " varchar(100) COLLATE "default",
"Dirección " varchar(100) COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of clientes
-- ----------------------------

-- ----------------------------
-- Table structure for equipo
-- ----------------------------
DROP TABLE IF EXISTS "public"."equipo";
CREATE TABLE "public"."equipo" (
"id" int8 DEFAULT nextval('equipo_id_seq'::regclass) NOT NULL,
"numero_serie_fat" int8,
"numero_serie" int8,
"articulo" varchar(255) COLLATE "default",
"status_llamada" varchar(255) COLLATE "default",
"grupo_articulos" varchar(255) COLLATE "default",
"prioridad" varchar(255) COLLATE "default",
"id_llamada" varchar(255) COLLATE "default",
"creado_el" date,
"cerrado_el" date,
"numero_contrato" int8,
"fecha_final" date,
"marca" varchar(255) COLLATE "default",
"modelo" varchar(255) COLLATE "default",
"ot" int8 NOT NULL
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of equipo
-- ----------------------------

-- ----------------------------
-- Table structure for ot
-- ----------------------------
DROP TABLE IF EXISTS "public"."ot";
CREATE TABLE "public"."ot" (
"id" int8 DEFAULT nextval('ot_id_seq'::regclass) NOT NULL,
"not" varchar(255) COLLATE "default" NOT NULL,
"nguiadespacho" varchar(255) COLLATE "default",
"idcliente" int8,
"idtipo" int8,
"idmarca" int8,
"idmodelo" int8,
"idrespingreso" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."ot"."id" IS 'identificador unico del registro';
COMMENT ON COLUMN "public"."ot"."not" IS 'numero de orden de trabajo';
COMMENT ON COLUMN "public"."ot"."nguiadespacho" IS 'numero de la guia de despacho con que lego el equipo';
COMMENT ON COLUMN "public"."ot"."idcliente" IS 'identificador unico del cliente';
COMMENT ON COLUMN "public"."ot"."idtipo" IS 'identificador unico del tipo del equipo';
COMMENT ON COLUMN "public"."ot"."idmarca" IS 'identificador unico de la marca del equipo';
COMMENT ON COLUMN "public"."ot"."idmodelo" IS 'identificador unico del modelo del equipo';
COMMENT ON COLUMN "public"."ot"."idrespingreso" IS 'Identificador del responsable del servicio';

-- ----------------------------
-- Records of ot
-- ----------------------------

-- ----------------------------
-- Table structure for permisos
-- ----------------------------
DROP TABLE IF EXISTS "public"."permisos";
CREATE TABLE "public"."permisos"()
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of permisos
-- ----------------------------

-- ----------------------------
-- Table structure for personal
-- ----------------------------
DROP TABLE IF EXISTS "public"."personal";
CREATE TABLE "public"."personal" (
"id" int8 DEFAULT nextval('personal_id_seq'::regclass) NOT NULL,
"nombres" varchar(150) COLLATE "default" NOT NULL,
"apellido_p" varchar(100) COLLATE "default" NOT NULL,
"apellido_m" varchar(100) COLLATE "default" NOT NULL,
"rut" varchar(100) COLLATE "default" NOT NULL,
"idcargo" int8,
"direccion" varchar(255) COLLATE "default",
"idpermiso" int8,
"imagenperfil" text COLLATE "default",
"username" varchar(255) COLLATE "default" NOT NULL,
"password" varchar(255) COLLATE "default" NOT NULL
)
WITH (OIDS=TRUE)

;
COMMENT ON COLUMN "public"."personal"."id" IS 'identificador universal del cliente';
COMMENT ON COLUMN "public"."personal"."nombres" IS 'nombres del operador';
COMMENT ON COLUMN "public"."personal"."apellido_p" IS 'apellido paterno del operador';
COMMENT ON COLUMN "public"."personal"."apellido_m" IS 'apellido materno del operador';
COMMENT ON COLUMN "public"."personal"."rut" IS 'rol unico tributario del operador (rut)';
COMMENT ON COLUMN "public"."personal"."idcargo" IS 'identificador unico del cargo que ocupa esta persona en la empresa.';
COMMENT ON COLUMN "public"."personal"."direccion" IS 'direccion fisica del operador';
COMMENT ON COLUMN "public"."personal"."idpermiso" IS 'identificador unico de la planilla del permiso.';
COMMENT ON COLUMN "public"."personal"."imagenperfil" IS 'nombre de la imagen para su busqueda en el dominio o servidor ftp para el temporal.';

-- ----------------------------
-- Records of personal
-- ----------------------------
INSERT INTO "public"."personal" VALUES ('4', 'Sebastian Jorge', 'Guajardo', 'Acevedo', '16438319-9', '1', 'Parinacota #1346', '1', null, 'kanyx', 'da1b129b74fc3783351aa1b2fc9c7d22');
INSERT INTO "public"."personal" VALUES ('5', 'Pilar Constanza ', 'Sáez', 'Contreras', '18261778-4', '2', 'Av. Escondida ', '2', null, 'pilarsaez', '31c7d084f0460fcde98ee9314fc8ef30');

-- ----------------------------
-- Table structure for proveedores 
-- ----------------------------
DROP TABLE IF EXISTS "public"."proveedores ";
CREATE TABLE "public"."proveedores " (
"id" int4,
"nombre" varchar(255) COLLATE "default",
"nombre_representante " varchar(255) COLLATE "default",
"telefono " int8,
"direccion " varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of proveedores 
-- ----------------------------

-- ----------------------------
-- Alter Sequences Owned By 
-- ----------------------------
ALTER SEQUENCE "public"."clientes_id_seq" OWNED BY "clientes"."id";
ALTER SEQUENCE "public"."ot_id_seq" OWNED BY "ot"."id";
ALTER SEQUENCE "public"."personal_id_seq" OWNED BY "personal"."id";

-- ----------------------------
-- Primary Key structure for table equipo
-- ----------------------------
ALTER TABLE "public"."equipo" ADD PRIMARY KEY ("id", "ot");

-- ----------------------------
-- Primary Key structure for table ot
-- ----------------------------
ALTER TABLE "public"."ot" ADD PRIMARY KEY ("id", "not");

-- ----------------------------
-- Primary Key structure for table personal
-- ----------------------------
ALTER TABLE "public"."personal" ADD PRIMARY KEY ("id", "rut");
