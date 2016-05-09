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

Date: 2016-05-09 10:30:46
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
-- Sequence structure for marca_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."marca_id_seq";
CREATE SEQUENCE "public"."marca_id_seq"
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
-- Sequence structure for tipos_productos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."tipos_productos_id_seq";
CREATE SEQUENCE "public"."tipos_productos_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

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
"razonsocial" varchar(100) COLLATE "default" NOT NULL,
"nconacto" varchar(100) COLLATE "default",
"apcontacto" varchar(255) COLLATE "default",
"fcontacto" varchar(100) COLLATE "default",
"mcontacto" varchar(100) COLLATE "default",
"fempresa" varchar(255) COLLATE "default",
"mempresa" varchar(255) COLLATE "default",
"dempresa" varchar(255) COLLATE "default",
"idciudad" int8,
"amcontacto" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."clientes"."razonsocial" IS 'razon social de la empresa';
COMMENT ON COLUMN "public"."clientes"."nconacto" IS 'nombre del contacto';
COMMENT ON COLUMN "public"."clientes"."apcontacto" IS 'apellido del contacto';
COMMENT ON COLUMN "public"."clientes"."fcontacto" IS 'telefono del contacto';
COMMENT ON COLUMN "public"."clientes"."mcontacto" IS 'correo electronico del contacto';
COMMENT ON COLUMN "public"."clientes"."fempresa" IS 'Telefono de la empresa';
COMMENT ON COLUMN "public"."clientes"."mempresa" IS 'correo electronico de la empresa';
COMMENT ON COLUMN "public"."clientes"."dempresa" IS 'Direccion de la empresa';
COMMENT ON COLUMN "public"."clientes"."idciudad" IS 'Identificador unico de la ciudad de la empresa';

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
-- Table structure for marcas
-- ----------------------------
DROP TABLE IF EXISTS "public"."marcas";
CREATE TABLE "public"."marcas" (
"id" int8 DEFAULT nextval('marca_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"idtipo" int8,
"pais" varchar(100) COLLATE "default",
"idproovedor" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."marcas"."id" IS 'identificador unico de la marca';
COMMENT ON COLUMN "public"."marcas"."pais" IS 'pais de procedencia de la marca';
COMMENT ON COLUMN "public"."marcas"."idproovedor" IS 'identificador del proveedor de la marca';

-- ----------------------------
-- Records of marcas
-- ----------------------------

-- ----------------------------
-- Table structure for ordenestrabajo
-- ----------------------------
DROP TABLE IF EXISTS "public"."ordenestrabajo";
CREATE TABLE "public"."ordenestrabajo" (
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
COMMENT ON COLUMN "public"."ordenestrabajo"."id" IS 'identificador unico del registro';
COMMENT ON COLUMN "public"."ordenestrabajo"."not" IS 'numero de orden de trabajo';
COMMENT ON COLUMN "public"."ordenestrabajo"."nguiadespacho" IS 'numero de la guia de despacho con que lego el equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."idcliente" IS 'identificador unico del cliente';
COMMENT ON COLUMN "public"."ordenestrabajo"."idtipo" IS 'identificador unico del tipo del equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."idmarca" IS 'identificador unico de la marca del equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."idmodelo" IS 'identificador unico del modelo del equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."idrespingreso" IS 'Identificador del responsable del servicio';

-- ----------------------------
-- Records of ordenestrabajo
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
INSERT INTO "public"."personal" VALUES ('5', 'Pilar Constanza ', 'Sáez', 'Contreras', '18261778-4', '1', 'Av. Escondida ', '1', null, 'pilarsaez', '31c7d084f0460fcde98ee9314fc8ef30');
INSERT INTO "public"."personal" VALUES ('6', 'Matías Alonso', 'Aliaga', 'Cortes', '16073376-4', '1', 'xxx', '1', null, 'maliaga', '79d3e1d76a45db2e2737f659dc68f872');

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
-- Table structure for tipos_productos
-- ----------------------------
DROP TABLE IF EXISTS "public"."tipos_productos";
CREATE TABLE "public"."tipos_productos" (
"id" int8 DEFAULT nextval('tipos_productos_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"comentario" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."tipos_productos"."id" IS 'Identificador unico del equipo';
COMMENT ON COLUMN "public"."tipos_productos"."nombre" IS 'nombre del tipo';
COMMENT ON COLUMN "public"."tipos_productos"."comentario" IS 'comentario del tipo';

-- ----------------------------
-- Records of tipos_productos
-- ----------------------------

-- ----------------------------
-- Alter Sequences Owned By 
-- ----------------------------
ALTER SEQUENCE "public"."clientes_id_seq" OWNED BY "clientes"."id";
ALTER SEQUENCE "public"."marca_id_seq" OWNED BY "marcas"."id";
ALTER SEQUENCE "public"."ot_id_seq" OWNED BY "ordenestrabajo"."id";
ALTER SEQUENCE "public"."personal_id_seq" OWNED BY "personal"."id";
ALTER SEQUENCE "public"."tipos_productos_id_seq" OWNED BY "tipos_productos"."id";

-- ----------------------------
-- Primary Key structure for table equipo
-- ----------------------------
ALTER TABLE "public"."equipo" ADD PRIMARY KEY ("id", "ot");

-- ----------------------------
-- Primary Key structure for table marcas
-- ----------------------------
ALTER TABLE "public"."marcas" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table ordenestrabajo
-- ----------------------------
ALTER TABLE "public"."ordenestrabajo" ADD PRIMARY KEY ("id", "not");

-- ----------------------------
-- Primary Key structure for table personal
-- ----------------------------
ALTER TABLE "public"."personal" ADD PRIMARY KEY ("id", "rut");
