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

Date: 2016-06-03 13:52:17
*/


-- ----------------------------
-- Sequence structure for ciudades_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ciudades_id_seq";
CREATE SEQUENCE "public"."ciudades_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 15
 CACHE 1;
SELECT setval('"public"."ciudades_id_seq"', 15, true);

-- ----------------------------
-- Sequence structure for clientes_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."clientes_id_seq";
CREATE SEQUENCE "public"."clientes_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 31
 CACHE 1;
SELECT setval('"public"."clientes_id_seq"', 31, true);

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
-- Sequence structure for estacionesmecanicas_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."estacionesmecanicas_id_seq";
CREATE SEQUENCE "public"."estacionesmecanicas_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 2
 CACHE 1;
SELECT setval('"public"."estacionesmecanicas_id_seq"', 2, true);

-- ----------------------------
-- Sequence structure for estados_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."estados_id_seq";
CREATE SEQUENCE "public"."estados_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 12
 CACHE 1;
SELECT setval('"public"."estados_id_seq"', 12, true);

-- ----------------------------
-- Sequence structure for flex_ots_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."flex_ots_id_seq";
CREATE SEQUENCE "public"."flex_ots_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 3
 CACHE 1;
SELECT setval('"public"."flex_ots_id_seq"', 3, true);

-- ----------------------------
-- Sequence structure for ingrepar_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ingrepar_id_seq";
CREATE SEQUENCE "public"."ingrepar_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 4
 CACHE 1;
SELECT setval('"public"."ingrepar_id_seq"', 4, true);

-- ----------------------------
-- Sequence structure for marca_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."marca_id_seq";
CREATE SEQUENCE "public"."marca_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 188
 CACHE 1;
SELECT setval('"public"."marca_id_seq"', 188, true);

-- ----------------------------
-- Sequence structure for med_componentes_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."med_componentes_id_seq";
CREATE SEQUENCE "public"."med_componentes_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 5
 CACHE 1;
SELECT setval('"public"."med_componentes_id_seq"', 5, true);

-- ----------------------------
-- Sequence structure for med_ots_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."med_ots_id_seq";
CREATE SEQUENCE "public"."med_ots_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 48
 CACHE 1;
SELECT setval('"public"."med_ots_id_seq"', 48, true);

-- ----------------------------
-- Sequence structure for med_parametros_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."med_parametros_id_seq";
CREATE SEQUENCE "public"."med_parametros_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 2
 CACHE 1;
SELECT setval('"public"."med_parametros_id_seq"', 2, true);

-- ----------------------------
-- Sequence structure for modelos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."modelos_id_seq";
CREATE SEQUENCE "public"."modelos_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 143
 CACHE 1;
SELECT setval('"public"."modelos_id_seq"', 143, true);

-- ----------------------------
-- Sequence structure for ot_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ot_id_seq";
CREATE SEQUENCE "public"."ot_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 20
 CACHE 1;
SELECT setval('"public"."ot_id_seq"', 20, true);

-- ----------------------------
-- Sequence structure for ot_inspvisual_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ot_inspvisual_id_seq";
CREATE SEQUENCE "public"."ot_inspvisual_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

-- ----------------------------
-- Sequence structure for otcomentarios_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."otcomentarios_id_seq";
CREATE SEQUENCE "public"."otcomentarios_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 14
 CACHE 1;
SELECT setval('"public"."otcomentarios_id_seq"', 14, true);

-- ----------------------------
-- Sequence structure for otimages_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."otimages_id_seq";
CREATE SEQUENCE "public"."otimages_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 60
 CACHE 1;
SELECT setval('"public"."otimages_id_seq"', 60, true);

-- ----------------------------
-- Sequence structure for paises_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."paises_id_seq";
CREATE SEQUENCE "public"."paises_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 388
 CACHE 1;
SELECT setval('"public"."paises_id_seq"', 388, true);

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
-- Sequence structure for subestados_ot_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."subestados_ot_id_seq";
CREATE SEQUENCE "public"."subestados_ot_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;

-- ----------------------------
-- Sequence structure for tipos_productos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."tipos_productos_id_seq";
CREATE SEQUENCE "public"."tipos_productos_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 29
 CACHE 1;
SELECT setval('"public"."tipos_productos_id_seq"', 29, true);

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
-- Table structure for ciudades
-- ----------------------------
DROP TABLE IF EXISTS "public"."ciudades";
CREATE TABLE "public"."ciudades" (
"id" int8 DEFAULT nextval('ciudades_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"idpais" int8
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of ciudades
-- ----------------------------
INSERT INTO "public"."ciudades" VALUES ('1', 'metropolitana', '232');
INSERT INTO "public"."ciudades" VALUES ('2', 'arica y parinacota', '232');
INSERT INTO "public"."ciudades" VALUES ('3', 'tarapacá', '232');
INSERT INTO "public"."ciudades" VALUES ('4', 'antofagasta', '232');
INSERT INTO "public"."ciudades" VALUES ('5', 'atacama', '232');
INSERT INTO "public"."ciudades" VALUES ('6', 'coquimbo', '232');
INSERT INTO "public"."ciudades" VALUES ('7', 'valparaíso', '232');
INSERT INTO "public"."ciudades" VALUES ('8', 'o''higgins', '232');
INSERT INTO "public"."ciudades" VALUES ('9', 'maule', '232');
INSERT INTO "public"."ciudades" VALUES ('10', 'biobío', '232');
INSERT INTO "public"."ciudades" VALUES ('11', 'la araucanía', '232');
INSERT INTO "public"."ciudades" VALUES ('12', 'los ríos', '232');
INSERT INTO "public"."ciudades" VALUES ('13', 'los lagos', '232');
INSERT INTO "public"."ciudades" VALUES ('14', 'aysén', '232');
INSERT INTO "public"."ciudades" VALUES ('15', 'magallanes y antártica', '232');

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS "public"."clientes";
CREATE TABLE "public"."clientes" (
"id" int8 DEFAULT nextval('clientes_id_seq'::regclass) NOT NULL,
"razonsocial" varchar(100) COLLATE "default" NOT NULL,
"ncontacto" varchar(100) COLLATE "default",
"apcontacto" varchar(255) COLLATE "default",
"fcontacto" varchar(100) COLLATE "default",
"mcontacto" varchar(100) COLLATE "default",
"fempresa" varchar(255) COLLATE "default",
"mempresa" varchar(255) COLLATE "default",
"dempresa" varchar(255) COLLATE "default",
"idciudad" int8,
"amcontacto" varchar(255) COLLATE "default",
"giroempresa" varchar(255) COLLATE "default",
"rut" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."clientes"."razonsocial" IS 'razon social de la empresa';
COMMENT ON COLUMN "public"."clientes"."ncontacto" IS 'nombre del contacto';
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
INSERT INTO "public"."clientes" VALUES ('1', 'EMPRESA NACIONAL DE MINERIA', null, null, null, null, '224355000', null, 'MAC IVER 459', null, null, 'FAB. METALES PRECIOSOS', '61703000-4');
INSERT INTO "public"."clientes" VALUES ('2', 'CORPORACION NACIONAL DEL COBRE', null, null, null, null, '226903000', null, 'HUERFANOS 1270', null, null, 'EXTRACCION COBRE', '61704000-K');
INSERT INTO "public"."clientes" VALUES ('3', 'ALGORTA NORTE S.A.', null, null, null, null, '227833900', null, 'LOS MILITARES 5890 PISO 5', null, null, 'EXTRACCION YODO Y NITRATO', '76000957-1');
INSERT INTO "public"."clientes" VALUES ('4', 'EMPRESA ELECTRICA ANGAMOS S.A.', null, null, null, null, '226868900', null, 'AV. ROSARIO NORTE 532, PISO 19 SANTIAGO', null, null, 'ENERGIA ELECTRICA', '76004976-K');
INSERT INTO "public"."clientes" VALUES ('5', 'COMPLEJO INDUSTRIAL MOLYNOR S.A.', null, null, null, null, '229376676', null, 'AV. PROLONGACION LONGITUDINAL N°6400', null, null, 'COM. PROD. Y DESPACHO OXIDO MOLIBDENO', '76016222-1');
INSERT INTO "public"."clientes" VALUES ('6', 'SIERRA GORDA SCM', null, null, null, null, '223665200', null, 'ISIDORA GOYENECHEA 3000, PISO 15', null, null, 'MINERIA', '76081590-K');
INSERT INTO "public"."clientes" VALUES ('7', 'CML COMERCIALIZADORA LTDA.', null, null, null, null, '552777577', null, 'LOS CHIRIHUES 9065', null, null, 'COMERCIALIZADORA', '76106291-3');
INSERT INTO "public"."clientes" VALUES ('8', 'PROVETEK INGENIERIA LTDA', null, null, null, null, '552763208', null, 'OVALLE 430', null, null, 'COMERCIALIZADORA', '76232301-K');
INSERT INTO "public"."clientes" VALUES ('9', 'IMPORT.Y COM. LUIS CUBILLOS VENEGAS E.I.R.L.', null, null, null, null, '225213243', null, 'GRAN AVENIDA JOSE MIGUEL CARRERA 4541, Of C ', null, null, 'COMERCIALIZADORA', '76337000-3');
INSERT INTO "public"."clientes" VALUES ('10', 'CONSTRUCTORA EXCON LTDA.', null, null, null, null, '225946628', null, 'Av. del Condor 550 Of. 103', null, null, 'CONSTRUCCION', '76443280-0');
INSERT INTO "public"."clientes" VALUES ('11', 'MINERA CENTINELA', null, null, null, null, '227987000', null, 'APOQUINDO 4001 PISO 18', null, null, 'MINERIA', '76727040-2');
INSERT INTO "public"."clientes" VALUES ('12', 'SULZER BOMBAS CHILE LTDA.', null, null, null, null, '223727910', null, 'LUIS CARRERA 1289 OF. 304', null, null, 'BOMBAS CENTRIFUGAS', '77249890-K');
INSERT INTO "public"."clientes" VALUES ('13', 'ANGLO AMERICAN SUR S.A.', null, null, null, null, '222306000', null, 'AV. PEDRO DE VALDIVIA N° 291', null, null, 'MINERIA', '77762940-9');
INSERT INTO "public"."clientes" VALUES ('14', 'PROPIPE S.A.', null, null, null, null, '552538600', null, 'GENERAL JOSE MANUEL BORGOÑO 934 OF 402', null, null, 'INGENIERIA', '77881200-2');
INSERT INTO "public"."clientes" VALUES ('15', 'ESCO INGENIERIA Y SERVICIOS LTDA.', null, null, null, null, '552215619', null, 'JUAN GLASINOVIC 480 GALPON 34', null, null, 'INGENIERIA', '77946090-8');
INSERT INTO "public"."clientes" VALUES ('16', 'FASTPACK S.A.', null, null, null, null, '224994000', null, 'SANTA ISABEL 850', null, null, 'ACEROS INOXIDABLES, FABRICACION Y COMERCIALIZACION', '78295070-3');
INSERT INTO "public"."clientes" VALUES ('17', 'INTERACID TRADING CHILE S.A.', null, null, null, null, '225666500', null, 'AV ISIDORA GOYENECHEA 3600 PISO 3', null, null, 'PRODUCTOS PARA MINERIA', '78378860-8');
INSERT INTO "public"."clientes" VALUES ('18', 'COMPAÑIA MINERA LOMAS BAYAS', null, null, null, null, '552628500', null, 'CAMINO MINSAL KM 36 S/N', null, null, 'MINERIA', '78512520-7');
INSERT INTO "public"."clientes" VALUES ('19', 'NORACID', null, null, null, null, '552883800', null, 'EL BOSQUE NORTE 500 PISO 16', null, null, 'ALMACENAMIENTO DE PRODUCTOS QUIMICOS', '78858530-K');
INSERT INTO "public"."clientes" VALUES ('20', 'SOCIEDAD TECNICA EN METALES LTDA', null, null, null, null, '722257310', null, 'LA CRUZ 550', null, null, 'FABRICACION', '79549400-6');
INSERT INTO "public"."clientes" VALUES ('21', 'MINERA ESCONDIDA LTDA.', null, null, null, null, '552247935', null, 'AV. DE LA MINERIA 501', null, null, 'EXPLOTACION MINAS', '79587210-8');
INSERT INTO "public"."clientes" VALUES ('22', 'SIHI CHILE S.A.', null, null, null, null, '227565900', null, 'AV.COLORADO NRO. 841', null, null, 'TRATAMIENTO AGUA', '79790600-K');
INSERT INTO "public"."clientes" VALUES ('23', 'SQM INDUSTRIAL S.A.', null, null, null, null, '224252000', null, 'LOS MILITARES 4290 PISO 3', null, null, 'FABRICACION PRODUCTOS MINERALES', '79947100-0');
INSERT INTO "public"."clientes" VALUES ('24', 'AGUAS INDUSTRIALES LTDA.', null, null, null, null, '222709500', null, 'PANAMERICANA NORTE 18900, INTERIOR', null, null, 'TRATAMIENTO AGUA', '80012700-9');
INSERT INTO "public"."clientes" VALUES ('25', 'COMPAÑIA MINERA ZALDIVAR S.A.', null, null, null, null, '552433400', null, 'AV. GRECIA 750', null, null, 'EXTRACCION MINERALES', '85758600-K');
INSERT INTO "public"."clientes" VALUES ('26', 'MINERA SPENCE S.A.', null, null, null, null, '552647800', null, 'GENERAL BORGOÑO 934, OF 1201', null, null, 'EXTRACCION COBRE', '86542100-1');
INSERT INTO "public"."clientes" VALUES ('27', 'COMPAÑIA MINERA MICHILLA S.A.', null, null, null, null, '227987000', null, 'AV APOQUINDO 4001 PISO 18', null, null, 'MINERIA', '91840000-1');
INSERT INTO "public"."clientes" VALUES ('28', 'CORP. TECNICA DE FLUIDOS S.A.', null, null, null, null, '228569500', null, 'AV. LA MONTAÑA 58, LOTEO IND. LOS LIBERTADORES', null, null, 'BOMBAS CENTRIFUGAS', '96599680-K');
INSERT INTO "public"."clientes" VALUES ('29', 'SEMBCORP AGUAS DEL NORTE S.A.', null, null, null, null, '552644200', null, 'AV EDMUNDO PEREZ ZUJOVIC 6444', null, null, 'TRATAMIENTO AGUA', '96706220-0');
INSERT INTO "public"."clientes" VALUES ('30', 'COMPAÑIA DE PETROLEOS DE CHILE COPEC S.A.', null, null, null, null, '226907000', null, 'AGUSTINAS 1382 PISO 2', null, null, 'ESTACIONES DE SERVICIOS', '99520000-7');
INSERT INTO "public"."clientes" VALUES ('31', 'AGUAS DE ANTOFAGASTA S.A.', null, null, null, null, '552356301', null, 'AV. PEDRO AGUIRRE CERDA 6496', null, null, 'TRATAMIENTO AGUA', '99540870-8');

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
-- Table structure for estacionesmecanicas
-- ----------------------------
DROP TABLE IF EXISTS "public"."estacionesmecanicas";
CREATE TABLE "public"."estacionesmecanicas" (
"id" int8 DEFAULT nextval('estacionesmecanicas_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"descripcion" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of estacionesmecanicas
-- ----------------------------
INSERT INTO "public"."estacionesmecanicas" VALUES ('1', 'mc1', 'Estacion 1');
INSERT INTO "public"."estacionesmecanicas" VALUES ('2', 'mc2', 'Estacion 2');

-- ----------------------------
-- Table structure for estados_ot
-- ----------------------------
DROP TABLE IF EXISTS "public"."estados_ot";
CREATE TABLE "public"."estados_ot" (
"id" int8 DEFAULT nextval('estados_id_seq'::regclass) NOT NULL,
"nestado" varchar(255) COLLATE "default",
"comentario" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of estados_ot
-- ----------------------------
INSERT INTO "public"."estados_ot" VALUES ('1', 'Diagnostico', null);
INSERT INTO "public"."estados_ot" VALUES ('2', 'Desarme', null);
INSERT INTO "public"."estados_ot" VALUES ('3', 'Cotizar', null);
INSERT INTO "public"."estados_ot" VALUES ('4', 'Espera OC', null);
INSERT INTO "public"."estados_ot" VALUES ('5', 'Espera Repuesto', null);
INSERT INTO "public"."estados_ot" VALUES ('6', 'Armado', null);
INSERT INTO "public"."estados_ot" VALUES ('7', 'Despacho', null);
INSERT INTO "public"."estados_ot" VALUES ('8', 'En Ruta', null);
INSERT INTO "public"."estados_ot" VALUES ('9', 'Cerrada OT', null);

-- ----------------------------
-- Table structure for flex_ots
-- ----------------------------
DROP TABLE IF EXISTS "public"."flex_ots";
CREATE TABLE "public"."flex_ots" (
"id" int8 DEFAULT nextval('flex_ots_id_seq'::regclass) NOT NULL,
"notrabajo" int8 NOT NULL,
"idcomponente" int8 NOT NULL,
"g0" numeric(3,2) NOT NULL,
"g45" numeric(3,2) NOT NULL,
"g90" numeric(3,2) NOT NULL,
"g135" numeric(3,2) NOT NULL,
"pos" int2 NOT NULL
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."flex_ots"."pos" IS 'posicion de la medicion (A=1 | B=2 | C=3 | D=4)';

-- ----------------------------
-- Records of flex_ots
-- ----------------------------
INSERT INTO "public"."flex_ots" VALUES ('1', '780', '1', '0.30', '0.40', '0.50', '0.60', '1');
INSERT INTO "public"."flex_ots" VALUES ('2', '780', '1', '0.10', '0.30', '0.40', '0.90', '2');
INSERT INTO "public"."flex_ots" VALUES ('3', '780', '1', '1.00', '0.90', '0.30', '0.80', '3');

-- ----------------------------
-- Table structure for ingrepar
-- ----------------------------
DROP TABLE IF EXISTS "public"."ingrepar";
CREATE TABLE "public"."ingrepar" (
"id" int8 DEFAULT nextval('ingrepar_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"idcliente" int8
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of ingrepar
-- ----------------------------
INSERT INTO "public"."ingrepar" VALUES ('0', 'sin ing. reparable', null);
INSERT INTO "public"."ingrepar" VALUES ('1', 'antonio olivares', '21');
INSERT INTO "public"."ingrepar" VALUES ('2', 'ralph castro', '21');
INSERT INTO "public"."ingrepar" VALUES ('3', 'adolfo roldan', '21');
INSERT INTO "public"."ingrepar" VALUES ('4', 'ricardo oyarzun', '21');

-- ----------------------------
-- Table structure for marcas
-- ----------------------------
DROP TABLE IF EXISTS "public"."marcas";
CREATE TABLE "public"."marcas" (
"id" int8 DEFAULT nextval('marca_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default" NOT NULL,
"idtipo" int8,
"idpais" varchar(100) COLLATE "default",
"idproovedor" varchar(255) COLLATE "default",
"iduseradd" int8
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."marcas"."id" IS 'identificador unico de la marca';
COMMENT ON COLUMN "public"."marcas"."idpais" IS 'pais de procedencia de la marca';
COMMENT ON COLUMN "public"."marcas"."idproovedor" IS 'identificador del proveedor de la marca';

-- ----------------------------
-- Records of marcas
-- ----------------------------
INSERT INTO "public"."marcas" VALUES ('144', 'ksb', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('145', 'sulzer', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('146', 'flowserve', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('147', 'goulds', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('148', 'itt', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('149', 'floway', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('150', 'warman', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('151', 'galigher', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('152', 'ahs', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('153', 'peerless', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('154', 'ingersoll dresser', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('155', 'wpil', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('156', 'neptuno', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('157', 'durco', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('158', 'ruhrpumpen', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('159', 'giw', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('160', 'vogel', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('161', 'wilfley', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('162', 'vogt', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('163', 'krebs', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('164', 'vms', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('165', 'bombatek', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('167', 'fedeco', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('168', 'fontaine', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('169', 'friatec', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('170', 'werner', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('171', 'nemo', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('172', 'grundfos', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('173', 'tsurumi', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('174', 'hyosung', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('175', 'faggiolati', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('176', 'toyo', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('177', 'flygt', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('178', 'spp', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('179', 'aurora', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('180', 'sihi', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('181', 'mono', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('182', 'metso', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('183', 'dragflow', '27', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('184', 'warman', '28', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('185', 'giw', '28', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('186', 'thomas', '28', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('187', 'vogt', '28', '0', null, null);
INSERT INTO "public"."marcas" VALUES ('188', 'ash', '28', '0', null, null);

-- ----------------------------
-- Table structure for med_componentes
-- ----------------------------
DROP TABLE IF EXISTS "public"."med_componentes";
CREATE TABLE "public"."med_componentes" (
"id" int8 DEFAULT nextval('med_componentes_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"idtipo" int8,
"idmodelo" int8
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."med_componentes"."id" IS 'identificador unico del componente';
COMMENT ON COLUMN "public"."med_componentes"."nombre" IS 'nombre del componente.';
COMMENT ON COLUMN "public"."med_componentes"."idtipo" IS 'identificador unico del tipo de producto al que pertenece este componente.';
COMMENT ON COLUMN "public"."med_componentes"."idmodelo" IS 'identificador unico en caso que el componente este asociado a un modelo en particular.';

-- ----------------------------
-- Records of med_componentes
-- ----------------------------
INSERT INTO "public"."med_componentes" VALUES ('1', 'eje', '27', null);
INSERT INTO "public"."med_componentes" VALUES ('2', 'carcasa', '27', null);
INSERT INTO "public"."med_componentes" VALUES ('3', 'camisa', '27', null);
INSERT INTO "public"."med_componentes" VALUES ('4', 'cpo. rod.', '27', null);
INSERT INTO "public"."med_componentes" VALUES ('5', 'impulsor', '27', null);

-- ----------------------------
-- Table structure for med_ots
-- ----------------------------
DROP TABLE IF EXISTS "public"."med_ots";
CREATE TABLE "public"."med_ots" (
"id" int8 DEFAULT nextval('med_ots_id_seq'::regclass) NOT NULL,
"notrabajo" int8 NOT NULL,
"idcomponente" int8 NOT NULL,
"g45" numeric(255,2),
"g90" numeric(255,2),
"g135" numeric(255,2),
"g180" numeric(255,2),
"apromedio" numeric,
"pos" int2,
"zona" int2
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of med_ots
-- ----------------------------
INSERT INTO "public"."med_ots" VALUES ('40', '780', '1', '50.00', '51.00', '52.00', '50.00', '50.75', '1', '1');
INSERT INTO "public"."med_ots" VALUES ('41', '780', '2', '50.00', '51.00', '52.00', '50.00', '50.75', '1', '1');
INSERT INTO "public"."med_ots" VALUES ('42', '780', '1', '0.90', '0.30', '0.80', '0.50', '0.625', '2', '1');
INSERT INTO "public"."med_ots" VALUES ('43', '780', '4', '50.00', '51.00', '52.00', '50.00', '50.75', '1', '1');
INSERT INTO "public"."med_ots" VALUES ('44', '780', '5', '50.00', '51.00', '52.00', '50.00', '50.75', '1', '1');
INSERT INTO "public"."med_ots" VALUES ('45', '780', '1', '0.50', '0.70', '0.80', '0.30', '0.575', '1', '2');
INSERT INTO "public"."med_ots" VALUES ('46', '781', '1', '50.00', '51.00', '52.00', '50.00', '50.75', '1', '1');
INSERT INTO "public"."med_ots" VALUES ('47', '781', '4', '50.00', '51.00', '52.00', '50.00', '50.75', '1', '1');
INSERT INTO "public"."med_ots" VALUES ('48', '780', '1', '11.00', '2.00', '5.00', '8.00', '6.5', '1', '3');

-- ----------------------------
-- Table structure for med_parametros
-- ----------------------------
DROP TABLE IF EXISTS "public"."med_parametros";
CREATE TABLE "public"."med_parametros" (
"id" int8 DEFAULT nextval('med_parametros_id_seq'::regclass) NOT NULL,
"idmodelo" int8,
"idtipo" int8,
"idcomponente" int8,
"apromedio" numeric(64,2),
"pos" int2,
"zona" int2
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."med_parametros"."idmodelo" IS 'en caso que estos parametros de medicion esten asociados a un modelo de producto desde la base de datos.';
COMMENT ON COLUMN "public"."med_parametros"."idtipo" IS 'identificador unico del tipo de producto al cual estan asociados estos parametros.';
COMMENT ON COLUMN "public"."med_parametros"."idcomponente" IS 'identificador unico del componente al cual esta apuntado esta medicion.';

-- ----------------------------
-- Records of med_parametros
-- ----------------------------

-- ----------------------------
-- Table structure for modelos
-- ----------------------------
DROP TABLE IF EXISTS "public"."modelos";
CREATE TABLE "public"."modelos" (
"id" int8 DEFAULT nextval('modelos_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"idmarca" int8,
"idtipo" int8,
"iduseradd" int8
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of modelos
-- ----------------------------
INSERT INTO "public"."modelos" VALUES ('1', 'cpk 250-500', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('2', 'cpk 200-400', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('3', 'cpk 200-315', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('4', 'megachem 150-315', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('5', 'megachem 150-400', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('6', 'megachem 65-250', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('7', 'megachem 65-125', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('8', 'megachem 40-125', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('9', 'rdl 300-340a', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('10', 'rdl v 400-390a', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('11', 'rdl 300-340b', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('12', 'multitec d32/4-21', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('13', 'meganorm 80-250', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('14', 'meganorm 150-500', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('15', 'meganorm 100-250', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('16', 'mtc 125/3.09', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('17', 'ama porter 502', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('18', 'wkl 80/4', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('19', 'movitec vcf 4/14b', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('20', 'movitec vcf 32/9', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('21', 'rdlv 400-390', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('22', 'hda 150/8', '144', '27', null);
INSERT INTO "public"."modelos" VALUES ('23', '14X12', '152', '27', null);
INSERT INTO "public"."modelos" VALUES ('24', '18X16', '152', '27', null);
INSERT INTO "public"."modelos" VALUES ('25', ' 8X8', '152', '27', null);
INSERT INTO "public"."modelos" VALUES ('26', 'srh 5 X 4', '188', '28', null);
INSERT INTO "public"."modelos" VALUES ('27', 'sm 150', '165', '27', null);
INSERT INTO "public"."modelos" VALUES ('28', '481 bf', '179', '27', null);
INSERT INTO "public"."modelos" VALUES ('29', 'el35a', '183', '27', null);
INSERT INTO "public"."modelos" VALUES ('30', '35 hp', '183', '27', null);
INSERT INTO "public"."modelos" VALUES ('31', 'el 25sb', '183', '27', null);
INSERT INTO "public"."modelos" VALUES ('32', 'el 04s la', '183', '27', null);
INSERT INTO "public"."modelos" VALUES ('33', 'el 60sa', '183', '27', null);
INSERT INTO "public"."modelos" VALUES ('34', '2k 4x3-10rv', '157', '27', null);
INSERT INTO "public"."modelos" VALUES ('35', '20-mkh', '149', '27', null);
INSERT INTO "public"."modelos" VALUES ('36', '18 tkh', '149', '27', null);
INSERT INTO "public"."modelos" VALUES ('37', '2k 4x3-10rv', '157', '27', null);
INSERT INTO "public"."modelos" VALUES ('38', 'mms 2043', '167', '27', null);
INSERT INTO "public"."modelos" VALUES ('39', 'mms-4040', '167', '27', null);
INSERT INTO "public"."modelos" VALUES ('40', 'x413r2c1-p80la5 sumergible', '175', '27', null);
INSERT INTO "public"."modelos" VALUES ('41', '14 m135-3e', '146', '27', null);
INSERT INTO "public"."modelos" VALUES ('42', '12 emm-7', '146', '27', null);
INSERT INTO "public"."modelos" VALUES ('43', '15 ehm-11', '146', '27', null);
INSERT INTO "public"."modelos" VALUES ('44', 'dmx 6x13 4 etapas', '146', '27', null);
INSERT INTO "public"."modelos" VALUES ('45', 'dmx 6x13 7 etapas', '146', '27', null);
INSERT INTO "public"."modelos" VALUES ('46', 'dmx 6x11 8 etapas', '146', '27', null);
INSERT INTO "public"."modelos" VALUES ('47', '18x16 vit -ff35bds', '146', '27', null);
INSERT INTO "public"."modelos" VALUES ('48', 'mtx 3196 2x3-8', '147', '27', null);
INSERT INTO "public"."modelos" VALUES ('49', 'xlt 3186', '147', '27', null);
INSERT INTO "public"."modelos" VALUES ('50', '3171  2 x 3 - 8', '147', '27', null);
INSERT INTO "public"."modelos" VALUES ('51', 'lf 3196 1,5 x 3 x 13', '147', '27', null);
INSERT INTO "public"."modelos" VALUES ('52', '5000(2 1/2)', '151', '27', null);
INSERT INTO "public"."modelos" VALUES ('53', '5000(3 1/2)', '151', '27', null);
INSERT INTO "public"."modelos" VALUES ('54', '5000(6)', '151', '27', null);
INSERT INTO "public"."modelos" VALUES ('55', '5000(4)', '151', '27', null);
INSERT INTO "public"."modelos" VALUES ('56', 'lcc-m100-400.2', '159', '27', null);
INSERT INTO "public"."modelos" VALUES ('57', 'lcc-m150-500.3k-gbmi', '159', '27', null);
INSERT INTO "public"."modelos" VALUES ('58', '6''''', '168', '27', null);
INSERT INTO "public"."modelos" VALUES ('59', 'rcnku 125-80', '169', '27', null);
INSERT INTO "public"."modelos" VALUES ('60', 'bleue /15 am 5u00 sumergible', '168', '27', null);
INSERT INTO "public"."modelos" VALUES ('61', '3060 ht', '177', '27', null);
INSERT INTO "public"."modelos" VALUES ('62', 'bs 2750.390', '177', '27', null);
INSERT INTO "public"."modelos" VALUES ('63', 'hs 5100.211', '177', '27', null);
INSERT INTO "public"."modelos" VALUES ('64', 'lcc-m150-500', '185', '28', null);
INSERT INTO "public"."modelos" VALUES ('65', '18x18', '185', '28', null);
INSERT INTO "public"."modelos" VALUES ('66', 'lcc 100-400', '185', '28', null);
INSERT INTO "public"."modelos" VALUES ('67', 'lcc 150-500', '185', '28', null);
INSERT INTO "public"."modelos" VALUES ('68', 'vit 4 etapas ff', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('69', '24x16 vit-ff ehxc 38ehc 2 etapas', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('70', '18x20 vit-ff dhxc 20chc 2 etapas', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('71', '8x13 vit-ff 4 etapas', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('72', '24x38 vit-ff ehxc 38ehc', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('73', '731 plus 3x1,5x11', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('74', '731 plus 6x4x10', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('75', '731 plus 10x8x15', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('76', '731  plus 8x6x17', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('77', '731 plus 4x3x11', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('78', 'pwo 6x8x13', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('79', 'pwo 12x10-17', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('80', 'pwo 8x6x14', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('81', 'vit ff 10 x 18 dhxc x 20 chc / 3', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('82', 'vit ff 18 x 16', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('83', 'vit 24 x 28 ehxg  38 ehc', '148', '27', null);
INSERT INTO "public"."modelos" VALUES ('84', 'd-1011 3x1,5-10', '154', '27', null);
INSERT INTO "public"."modelos" VALUES ('85', 'vtp 8 inches', '154', '27', null);
INSERT INTO "public"."modelos" VALUES ('86', 'ra100-a43-4x4-12', '163', '27', null);
INSERT INTO "public"."modelos" VALUES ('87', 'cr32-9-2', '172', '27', null);
INSERT INTO "public"."modelos" VALUES ('88', 'hes 80-400', '174', '27', null);
INSERT INTO "public"."modelos" VALUES ('89', 'cae12h1r3/h1', '181', '27', null);
INSERT INTO "public"."modelos" VALUES ('90', 'vt-80 c4 hc', '182', '27', null);
INSERT INTO "public"."modelos" VALUES ('91', 'msd 6x10x15c 6 etapas', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('92', 'msd 8x10x13 az 4 etapas', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('93', 'msd 8x10x13 bz 5 etapas', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('94', 'msd 8x10x13 bz 4 etapas', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('95', 'msd 8x10x15c 6 etapas', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('96', 'a31-150', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('97', 'a33-80', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('98', 'a53-150', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('99', 'a21-100', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('100', 'a31-125', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('101', 'smnv 202-450', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('102', 'smh 252-400', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('103', 'ah-50', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('104', 'ze 80-3400', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('105', 'abs j 205 nd 24/21', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('106', 'ze 40-3400', '145', '27', null);
INSERT INTO "public"."modelos" VALUES ('107', '6x4 ah', '150', '27', null);
INSERT INTO "public"."modelos" VALUES ('108', '16x14 tu-ahpp', '150', '27', null);
INSERT INTO "public"."modelos" VALUES ('109', '8 x 6', '150', '27', null);
INSERT INTO "public"."modelos" VALUES ('110', '18 x 16', '150', '27', null);
INSERT INTO "public"."modelos" VALUES ('111', '16 x 14', '150', '27', null);
INSERT INTO "public"."modelos" VALUES ('112', 'spr 100 vertical', '150', '27', null);
INSERT INTO "public"."modelos" VALUES ('113', 'm12ld', '153', '27', null);
INSERT INTO "public"."modelos" VALUES ('114', '1000x250 8 etapas', '155', '27', null);
INSERT INTO "public"."modelos" VALUES ('115', 'vit neptuno 1 etapa (8")', '156', '27', null);
INSERT INTO "public"."modelos" VALUES ('116', 'zmi 480/03', '158', '27', null);
INSERT INTO "public"."modelos" VALUES ('117', 'l50 mrs 4 etapas', '160', '27', null);
INSERT INTO "public"."modelos" VALUES ('118', 'mp 125.1 3 etapas', '160', '27', null);
INSERT INTO "public"."modelos" VALUES ('119', '4x2,5 kpro', '161', '27', null);
INSERT INTO "public"."modelos" VALUES ('120', '660 ars', '162', '27', null);
INSERT INTO "public"."modelos" VALUES ('121', 'cz 80-315', '164', '27', null);
INSERT INTO "public"."modelos" VALUES ('122', 'vc-540', '162', '27', null);
INSERT INTO "public"."modelos" VALUES ('123', 'nepd 200-150-250', '170', '27', null);
INSERT INTO "public"."modelos" VALUES ('124', 'nmo31sy0s1', '171', '27', null);
INSERT INTO "public"."modelos" VALUES ('125', 'gpn3-100 sumergible', '173', '27', null);
INSERT INTO "public"."modelos" VALUES ('126', 'dpf 20b mt2 sumergible', '176', '27', null);
INSERT INTO "public"."modelos" VALUES ('127', 'tc12g', '178', '27', null);
INSERT INTO "public"."modelos" VALUES ('128', 'now bl 3226', '180', '27', null);
INSERT INTO "public"."modelos" VALUES ('129', 'sc 32/26-16', '180', '27', null);
INSERT INTO "public"."modelos" VALUES ('130', '80sfq215 sumergible', '173', '27', null);
INSERT INTO "public"."modelos" VALUES ('131', 'u005', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('132', 't005', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('133', 'd005 d21', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('134', 'm24 0005', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('135', '5x4 srh', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('136', '5x6 ahs', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('137', 'g005 im', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('138', '4 x 3', '184', '28', null);
INSERT INTO "public"."modelos" VALUES ('139', '12x14', '186', '28', null);
INSERT INTO "public"."modelos" VALUES ('140', '18 x16', '186', '28', null);
INSERT INTO "public"."modelos" VALUES ('141', 'vc-540', '187', '28', null);
INSERT INTO "public"."modelos" VALUES ('142', 'vc-528', '187', '28', null);
INSERT INTO "public"."modelos" VALUES ('143', 'vit ff 8x13 cmc 4', '147', '27', null);

-- ----------------------------
-- Table structure for ordenestrabajo
-- ----------------------------
DROP TABLE IF EXISTS "public"."ordenestrabajo";
CREATE TABLE "public"."ordenestrabajo" (
"id" int8 DEFAULT nextval('ot_id_seq'::regclass) NOT NULL,
"notrabajo" varchar(255) COLLATE "default" NOT NULL,
"nguiadespacho" varchar(255) COLLATE "default",
"idcliente" int8,
"idtipo" int8,
"idmarca" int8,
"idmodelo" int8,
"nserie" varchar(255) COLLATE "default",
"prioridad" varchar(255) COLLATE "default" NOT NULL,
"numerocontrato" varchar(255) COLLATE "default",
"fecha_ingreso" date,
"nseriefabricante" varchar(255) COLLATE "default",
"fecha_cierre" date,
"idestado" int8,
"tipo" int2,
"noc" varchar(64) COLLATE "default",
"nagendamiento" varchar(255) COLLATE "default",
"idrespingreso" int8,
"tag" varchar(255) COLLATE "default",
"ingrepaid" int8 DEFAULT 0 NOT NULL,
"idmechanicstation" int8 DEFAULT 0 NOT NULL
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."ordenestrabajo"."id" IS 'identificador unico del registro';
COMMENT ON COLUMN "public"."ordenestrabajo"."notrabajo" IS 'numero de orden de trabajo';
COMMENT ON COLUMN "public"."ordenestrabajo"."nguiadespacho" IS 'numero de la guia de despacho con que lego el equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."idcliente" IS 'identificador unico del cliente';
COMMENT ON COLUMN "public"."ordenestrabajo"."idtipo" IS 'identificador unico del tipo del equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."idmarca" IS 'identificador unico de la marca del equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."idmodelo" IS 'identificador unico del modelo del equipo';
COMMENT ON COLUMN "public"."ordenestrabajo"."tipo" IS 'Tipo de orden de trabajo / 1 - Reparacion | 2 - Garantia';
COMMENT ON COLUMN "public"."ordenestrabajo"."nagendamiento" IS 'Numero de orden de flete generalmente entregado por linsa.';
COMMENT ON COLUMN "public"."ordenestrabajo"."tag" IS 'TAG identificador interno del equipo por parte del cliente';
COMMENT ON COLUMN "public"."ordenestrabajo"."ingrepaid" IS 'Identificador unico del ingeniero reparable.';
COMMENT ON COLUMN "public"."ordenestrabajo"."idmechanicstation" IS 'Identificador unico de la estacion mecanica a la cual se asigno esta orden de trabajo.';

-- ----------------------------
-- Records of ordenestrabajo
-- ----------------------------
INSERT INTO "public"."ordenestrabajo" VALUES ('3', '1', '123456', '1', '27', '144', '2', '1234567890', '', '1234567890', '2016-05-11', '123456789', null, '1', '1', '1234567', '123456767', '4', null, '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('4', '2', '1234567', '1', '27', '144', '1', '77777777777', '', '99999999999', '2016-05-11', '88888888888', null, '1', '1', '654321', '1234567', '4', null, '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('6', '4', '4334', '2', '27', '144', '2', '777', 'baja', '', '2016-05-12', '', null, '1', '1', '555', '5555', '6', null, '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('7', '5', '22222222', '2', '27', '144', '1', '6666666', 'alta', '8888888', '2016-05-12', '7777777', null, '1', '1', '3333333', '4444444', '4', '5555555', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('8', '6', '22222', '1', '27', '144', '1', '6666666', '', '888888888', '2016-05-12', '7777777', null, '1', '1', '333333', '44444444', '4', '5555555', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('9', '7', '665', '8', '27', '144', '3', '1212', '', '1000', '2016-05-26', '12345', null, '1', '2', '87768768', '798798', '6', 'Bomba 21', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('10', '776', '64581', '21', '27', '147', '143', '8-2016', '', 'sin contrato', '2016-05-12', '314450', null, '1', '1', '4504471338', '12', '8', 'AGUA MINA', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('11', '777', '11111', '2', '27', '165', '27', '111111', '', '1111111', '2016-05-13', '11111', null, '1', '1', '11111', '111111', '6', '11111', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('13', '779', '515', '3', '28', '185', '65', '778-2016', '', 'nvnrnjn', '2016-05-16', '75664674', null, '1', '1', '4662452145', '562', '7', 'bueche', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('14', '780', '123456', '21', '27', '152', '23', '1234567890', 'baja', '1244e535435345', '2016-05-16', '1234567890', null, '1', '1', '123456', '123456', '4', '1234567890', '2', '1');
INSERT INTO "public"."ordenestrabajo" VALUES ('15', '781', '2656', '21', '27', '144', '15', '562656', '', '', '2016-05-18', '', null, '2', '1', '55622', '1566', '7', '15522626', '2', '1');
INSERT INTO "public"."ordenestrabajo" VALUES ('16', '782', '1234', '5', '27', '179', '28', '654321', 'baja', '345678', '2016-05-26', '98765', null, '1', '1', '1234', '4321', '4', 'BOMBA INT. AG', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('17', '783', '64637', '21', '27', '144', '11', '783-2016', '', '', '2016-05-20', '667917', null, '1', '1', '4504454682', '43709', '8', '3500-5PPP-286', '2', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('18', '784', '64644', '21', '28', '188', '26', '690-2016', '', '', '2016-05-23', '', null, '1', '2', '4504492491', '43971', '8', '10871565', '3', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('19', '785', '11111', '1', '27', '175', '40', '785-2016', '', '', '2016-05-30', '111111', null, '1', '1', '11111', '111111', '8', '1111111', '0', '0');
INSERT INTO "public"."ordenestrabajo" VALUES ('20', '786', '222222', '1', '27', '179', '28', '786-2016', '', '2222222222222222222222', '2016-05-30', '22222222222', null, '1', '1', '22222', '22222', '4', '2222', '0', '0');

-- ----------------------------
-- Table structure for ot_inspvisual
-- ----------------------------
DROP TABLE IF EXISTS "public"."ot_inspvisual";
CREATE TABLE "public"."ot_inspvisual" (
"id" int8 DEFAULT nextval('ot_inspvisual_id_seq'::regclass) NOT NULL,
"idot" int8,
"idcomponente" int8,
"z1" int2 DEFAULT 0 NOT NULL,
"z2" int2 DEFAULT 0 NOT NULL,
"z3" int2 DEFAULT 0 NOT NULL,
"z4" int2 DEFAULT 0 NOT NULL,
"z5" int2 DEFAULT 0 NOT NULL,
"z6" int2 DEFAULT 0 NOT NULL,
"z7" int2 DEFAULT 0 NOT NULL,
"z8" int2 DEFAULT 0 NOT NULL,
"z9" int2 DEFAULT 0 NOT NULL,
"z10" int2 DEFAULT 0 NOT NULL,
"z11" int2 DEFAULT 0 NOT NULL,
"z12" int2 DEFAULT 0 NOT NULL,
"z13" int2 DEFAULT 0 NOT NULL,
"z14" int2 DEFAULT 0 NOT NULL,
"z15" int2 DEFAULT 0 NOT NULL,
"z16" int2 DEFAULT 0 NOT NULL,
"z17" int2 DEFAULT 0 NOT NULL,
"z18" int2 DEFAULT 0 NOT NULL,
"z19" int2 DEFAULT 0 NOT NULL,
"z20" int2 DEFAULT 0 NOT NULL,
"z21" int2 DEFAULT 0 NOT NULL,
"z22" int2 DEFAULT 0 NOT NULL
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."ot_inspvisual"."idot" IS 'Identificador unico de la orden de trabajo.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z1" IS 'EJE: cond. hilo de tuerca fijacion de rodamiento.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z2" IS 'EJE: cond. chaveta y chavetero.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z3" IS 'CARCASA: cond. de zona ajuste.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z4" IS 'CARCASA: cond. de flange.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z5" IS 'CARCASA: cond. patas de apoyo.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z6" IS 'IMPULSOR: cond. Ø hilo interior';
COMMENT ON COLUMN "public"."ot_inspvisual"."z7" IS 'IMPULSOR: cond. chavetero impulsor.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z8" IS 'IMPULSOR: cond. alabes.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z9" IS 'FRAME ADAPTER: cond. de caras frontales.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z10" IS 'FRAME ADAPTER: cond. de hilos y agujeros.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z11" IS 'FRAME ADAPTER: cond. de pestaña ajuste.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z12" IS 'FRAME ADAPTER: cond. de alojamiento laberinto.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z13" IS 'STAFIN BOX: cond. cara frontal.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z14" IS 'STAFIN BOX: cond. de esparragos.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z15" IS 'STAFIN BOX: cond. de lineas de refrigeracion.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z16" IS 'CPO. ROD: cond. de hilo de amarre de frame.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z17" IS 'CPO. ROD: cond. de seguro rod. axial.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z18" IS 'CPO. ROD: cond. de seguro radial.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z19" IS 'SELLO MECANICO: cond. de caras de contacto.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z20" IS 'SELLO MECANICO: cond. de collarin.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z21" IS 'SELLO MECANICO: cond. de o''ring.';
COMMENT ON COLUMN "public"."ot_inspvisual"."z22" IS 'SELLO MECANICO: tipo de sello.';

-- ----------------------------
-- Records of ot_inspvisual
-- ----------------------------

-- ----------------------------
-- Table structure for otcomentarios
-- ----------------------------
DROP TABLE IF EXISTS "public"."otcomentarios";
CREATE TABLE "public"."otcomentarios" (
"id" int8 DEFAULT nextval('otcomentarios_id_seq'::regclass) NOT NULL,
"iduser" int8,
"comentario" text COLLATE "default",
"idot" int8,
"fecha" date,
"hora" time(6)
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."otcomentarios"."fecha" IS 'Hora que se ingreso el comentario';
COMMENT ON COLUMN "public"."otcomentarios"."hora" IS 'hora que se ingreso el comentario.';

-- ----------------------------
-- Records of otcomentarios
-- ----------------------------
INSERT INTO "public"."otcomentarios" VALUES ('1', '4', 'asasasasas', '1', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('2', '4', 'prueba de ingreso', '2', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('3', '4', 'una simple prueba de ingreso de un producto al taller.', '5', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('4', '4', 'prueba ingreso ot ahora si !', '6', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('5', '6', 'Equipo sin Machon de acoplamiento', '7', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('6', '8', 'EQUIPO SE RECEPCIONA EN PALLET', '8', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('7', '6', 'aaaaaaaaaaaaaaaaaa', '777', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('8', '4', '11111111111111', '778', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('9', '7', 'EQUIPO VIENE POR REPARACION NORMAL, NO PAORTE REPUESTOS', '779', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('10', '4', 'prueba de orden de trabajo.', '780', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('11', '4', 'prueba OT', '782', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('12', '8', 'EQUIPO INGRESA DESARMADO
SE RECEPCIONA EQUIPO EN ATRIL METALICO', '783', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('13', '8', 'boooooooorrrrrrrraaaaaaarrr', '785', null, null);
INSERT INTO "public"."otcomentarios" VALUES ('14', '4', 'prueba elimar', '786', null, null);

-- ----------------------------
-- Table structure for otimages
-- ----------------------------
DROP TABLE IF EXISTS "public"."otimages";
CREATE TABLE "public"."otimages" (
"id" int8 DEFAULT nextval('otimages_id_seq'::regclass) NOT NULL,
"nimagen" varchar(255) COLLATE "default",
"idot" int8,
"imgcomentario" text COLLATE "default"
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."otimages"."imgcomentario" IS 'Comentario de ima imagen (Solicitado por Andres Morales)';

-- ----------------------------
-- Records of otimages
-- ----------------------------
INSERT INTO "public"."otimages" VALUES ('1', 'Chrysanthemum.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('2', 'Desert.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('3', 'Hydrangeas.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('4', 'Jellyfish.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('5', 'Koala.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('6', 'Lighthouse.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('7', 'Penguins.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('8', 'Tulips.jpg', '2', null);
INSERT INTO "public"."otimages" VALUES ('9', 'ingresoot_add_foto.png', '2', null);
INSERT INTO "public"."otimages" VALUES ('10', 'dia-45-flora-black-domina-13.jpg', '5', null);
INSERT INTO "public"."otimages" VALUES ('11', 'Dinafem-Critical+10-8959_product_gallery.jpg', '5', null);
INSERT INTO "public"."otimages" VALUES ('12', 'Moby_Dick_clone_No_2_buds.jpg', '5', null);
INSERT INTO "public"."otimages" VALUES ('13', 'OG-Kush-Plants.jpg', '5', null);
INSERT INTO "public"."otimages" VALUES ('14', 'dia-45-flora-black-domina-13.jpg', '6', null);
INSERT INTO "public"."otimages" VALUES ('15', 'Dinafem-Critical+10-8959_product_gallery.jpg', '6', null);
INSERT INTO "public"."otimages" VALUES ('16', 'Moby_Dick_clone_No_2_buds.jpg', '6', null);
INSERT INTO "public"."otimages" VALUES ('17', 'OG-Kush-Plants.jpg', '6', null);
INSERT INTO "public"."otimages" VALUES ('18', 'RepairCo -1.jpg', '7', null);
INSERT INTO "public"."otimages" VALUES ('19', 'RepairCo -20.jpg', '7', null);
INSERT INTO "public"."otimages" VALUES ('20', 'RepairCo -9.jpg', '7', null);
INSERT INTO "public"."otimages" VALUES ('21', 'RepairCo -14.jpg', '7', null);
INSERT INTO "public"."otimages" VALUES ('22', 'IMG_20160512_103742870.jpg', '8', null);
INSERT INTO "public"."otimages" VALUES ('23', 'IMG_20160512_103756266.jpg', '8', null);
INSERT INTO "public"."otimages" VALUES ('24', 'IMG_20160512_103810983.jpg', '8', null);
INSERT INTO "public"."otimages" VALUES ('25', 'IMG_20160512_103827977.jpg', '8', null);
INSERT INTO "public"."otimages" VALUES ('26', 'dia-45-flora-black-domina-13.jpg', '778', null);
INSERT INTO "public"."otimages" VALUES ('27', 'Dinafem-Critical+10-8959_product_gallery.jpg', '778', null);
INSERT INTO "public"."otimages" VALUES ('28', 'Moby_Dick_clone_No_2_buds.jpg', '778', null);
INSERT INTO "public"."otimages" VALUES ('29', 'OG-Kush-Plants.jpg', '778', null);
INSERT INTO "public"."otimages" VALUES ('30', 'IMG_20160509_113856995.jpg', '779', null);
INSERT INTO "public"."otimages" VALUES ('31', 'IMG_20160509_113910021.jpg', '779', null);
INSERT INTO "public"."otimages" VALUES ('32', 'IMG_20160509_113920205.jpg', '779', null);
INSERT INTO "public"."otimages" VALUES ('33', 'IMG_20160509_114028250.jpg', '779', null);
INSERT INTO "public"."otimages" VALUES ('34', 'Chrysanthemum.jpg', '780', null);
INSERT INTO "public"."otimages" VALUES ('35', 'Desert.jpg', '780', null);
INSERT INTO "public"."otimages" VALUES ('36', 'Koala.jpg', '780', null);
INSERT INTO "public"."otimages" VALUES ('37', 'Lighthouse.jpg', '780', null);
INSERT INTO "public"."otimages" VALUES ('38', 'IMG_20160509_113856995.jpg', '781', null);
INSERT INTO "public"."otimages" VALUES ('39', 'IMG_20160509_113910021.jpg', '781', null);
INSERT INTO "public"."otimages" VALUES ('40', 'IMG_20160509_113920205.jpg', '781', null);
INSERT INTO "public"."otimages" VALUES ('41', 'IMG_20160509_114028250.jpg', '781', null);
INSERT INTO "public"."otimages" VALUES ('42', 'Chrysanthemum.jpg', '782', null);
INSERT INTO "public"."otimages" VALUES ('43', 'Desert.jpg', '782', null);
INSERT INTO "public"."otimages" VALUES ('44', 'Koala.jpg', '782', null);
INSERT INTO "public"."otimages" VALUES ('45', 'Lighthouse.jpg', '782', null);
INSERT INTO "public"."otimages" VALUES ('46', '6f6801fc-d4e8-4380-baac-e1e24868b678.jpg', '783', null);
INSERT INTO "public"."otimages" VALUES ('47', '726ba58c-05fb-4ed6-ad14-78c2c93c578e.jpg', '783', null);
INSERT INTO "public"."otimages" VALUES ('48', '935b3a6e-6502-49f4-91c1-cd7cf6f441c0.jpg', '783', null);
INSERT INTO "public"."otimages" VALUES ('49', 'b57e8d65-3ea3-4a1d-992f-d2fe0d8cd01d.jpg', '783', null);
INSERT INTO "public"."otimages" VALUES ('50', '783ece2c-27fa-465d-9282-15a3a563d4fb.jpg', '784', null);
INSERT INTO "public"."otimages" VALUES ('51', '0763998b-284b-4217-907e-e01f19620e1f.jpg', '784', null);
INSERT INTO "public"."otimages" VALUES ('52', 'ce526c7c-ba4e-482c-994b-df5671b0dcc7.jpg', '784', null);
INSERT INTO "public"."otimages" VALUES ('53', 'Chrysanthemum.jpg', '786', null);
INSERT INTO "public"."otimages" VALUES ('54', 'Desert.jpg', '786', null);
INSERT INTO "public"."otimages" VALUES ('55', 'Hydrangeas.jpg', '786', null);
INSERT INTO "public"."otimages" VALUES ('56', 'Jellyfish.jpg', '786', null);
INSERT INTO "public"."otimages" VALUES ('57', 'Koala.jpg', '786', null);
INSERT INTO "public"."otimages" VALUES ('58', 'Lighthouse.jpg', '786', null);
INSERT INTO "public"."otimages" VALUES ('59', 'Penguins.jpg', '786', null);
INSERT INTO "public"."otimages" VALUES ('60', 'Tulips.jpg', '786', null);

-- ----------------------------
-- Table structure for paises
-- ----------------------------
DROP TABLE IF EXISTS "public"."paises";
CREATE TABLE "public"."paises" (
"id" int8 DEFAULT nextval('paises_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"iduseradd" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."paises"."iduseradd" IS 'Identificador unico de usuario que añadio el pais.';

-- ----------------------------
-- Records of paises
-- ----------------------------
INSERT INTO "public"."paises" VALUES ('195', 'Afganistán', null);
INSERT INTO "public"."paises" VALUES ('196', 'Albania', null);
INSERT INTO "public"."paises" VALUES ('197', 'Alemania', null);
INSERT INTO "public"."paises" VALUES ('198', 'Andorra', null);
INSERT INTO "public"."paises" VALUES ('199', 'Angola', null);
INSERT INTO "public"."paises" VALUES ('200', 'Antigua y Barbuda', null);
INSERT INTO "public"."paises" VALUES ('201', 'Arabia Saudita', null);
INSERT INTO "public"."paises" VALUES ('202', 'Argelia', null);
INSERT INTO "public"."paises" VALUES ('203', 'Argentina', null);
INSERT INTO "public"."paises" VALUES ('204', 'Armenia', null);
INSERT INTO "public"."paises" VALUES ('205', 'Australia', null);
INSERT INTO "public"."paises" VALUES ('206', 'Austria', null);
INSERT INTO "public"."paises" VALUES ('207', 'Azerbaiyán', null);
INSERT INTO "public"."paises" VALUES ('208', 'Bahamas', null);
INSERT INTO "public"."paises" VALUES ('209', 'Bangladés', null);
INSERT INTO "public"."paises" VALUES ('210', 'Barbados', null);
INSERT INTO "public"."paises" VALUES ('211', 'Baréin', null);
INSERT INTO "public"."paises" VALUES ('212', 'Bélgica', null);
INSERT INTO "public"."paises" VALUES ('213', 'Belice', null);
INSERT INTO "public"."paises" VALUES ('214', 'Benín', null);
INSERT INTO "public"."paises" VALUES ('215', 'Bielorrusia', null);
INSERT INTO "public"."paises" VALUES ('216', 'Birmania', null);
INSERT INTO "public"."paises" VALUES ('217', 'Bolivia', null);
INSERT INTO "public"."paises" VALUES ('218', 'Bosnia y Herzegovina', null);
INSERT INTO "public"."paises" VALUES ('219', 'Botsuana', null);
INSERT INTO "public"."paises" VALUES ('220', 'Brasil', null);
INSERT INTO "public"."paises" VALUES ('221', 'Brunéi', null);
INSERT INTO "public"."paises" VALUES ('222', 'Bulgaria', null);
INSERT INTO "public"."paises" VALUES ('223', 'Burkina Faso', null);
INSERT INTO "public"."paises" VALUES ('224', 'Burundi', null);
INSERT INTO "public"."paises" VALUES ('225', 'Bután', null);
INSERT INTO "public"."paises" VALUES ('226', 'Cabo Verde', null);
INSERT INTO "public"."paises" VALUES ('227', 'Camboya', null);
INSERT INTO "public"."paises" VALUES ('228', 'Camerún', null);
INSERT INTO "public"."paises" VALUES ('229', 'Canadá', null);
INSERT INTO "public"."paises" VALUES ('230', 'Catar', null);
INSERT INTO "public"."paises" VALUES ('231', 'Chad', null);
INSERT INTO "public"."paises" VALUES ('232', 'Chile', null);
INSERT INTO "public"."paises" VALUES ('233', 'China', null);
INSERT INTO "public"."paises" VALUES ('234', 'Chipre', null);
INSERT INTO "public"."paises" VALUES ('235', 'Ciudad del Vaticano', null);
INSERT INTO "public"."paises" VALUES ('236', 'Colombia', null);
INSERT INTO "public"."paises" VALUES ('237', 'Comoras', null);
INSERT INTO "public"."paises" VALUES ('238', 'Corea del Norte', null);
INSERT INTO "public"."paises" VALUES ('239', 'Corea del Sur', null);
INSERT INTO "public"."paises" VALUES ('240', 'Costa de Marfil', null);
INSERT INTO "public"."paises" VALUES ('241', 'Costa Rica', null);
INSERT INTO "public"."paises" VALUES ('242', 'Croacia', null);
INSERT INTO "public"."paises" VALUES ('243', 'Cuba', null);
INSERT INTO "public"."paises" VALUES ('244', 'Dinamarca', null);
INSERT INTO "public"."paises" VALUES ('245', 'Dominica', null);
INSERT INTO "public"."paises" VALUES ('246', 'Ecuador', null);
INSERT INTO "public"."paises" VALUES ('247', 'Egipto', null);
INSERT INTO "public"."paises" VALUES ('248', 'El Salvador', null);
INSERT INTO "public"."paises" VALUES ('249', 'Emiratos Árabes Unidos', null);
INSERT INTO "public"."paises" VALUES ('250', 'Eritrea', null);
INSERT INTO "public"."paises" VALUES ('251', 'Eslovaquia', null);
INSERT INTO "public"."paises" VALUES ('252', 'Eslovenia', null);
INSERT INTO "public"."paises" VALUES ('253', 'España', null);
INSERT INTO "public"."paises" VALUES ('254', 'Estados Unidos', null);
INSERT INTO "public"."paises" VALUES ('255', 'Estonia', null);
INSERT INTO "public"."paises" VALUES ('256', 'Etiopía', null);
INSERT INTO "public"."paises" VALUES ('257', 'Filipinas', null);
INSERT INTO "public"."paises" VALUES ('258', 'Finlandia', null);
INSERT INTO "public"."paises" VALUES ('259', 'Fiyi', null);
INSERT INTO "public"."paises" VALUES ('260', 'Francia', null);
INSERT INTO "public"."paises" VALUES ('261', 'Gabón', null);
INSERT INTO "public"."paises" VALUES ('262', 'Gambia', null);
INSERT INTO "public"."paises" VALUES ('263', 'Georgia', null);
INSERT INTO "public"."paises" VALUES ('264', 'Ghana', null);
INSERT INTO "public"."paises" VALUES ('265', 'Granada', null);
INSERT INTO "public"."paises" VALUES ('266', 'Grecia', null);
INSERT INTO "public"."paises" VALUES ('267', 'Guatemala', null);
INSERT INTO "public"."paises" VALUES ('268', 'Guyana', null);
INSERT INTO "public"."paises" VALUES ('269', 'Guinea', null);
INSERT INTO "public"."paises" VALUES ('270', 'Guinea ecuatorial', null);
INSERT INTO "public"."paises" VALUES ('271', 'Guinea-Bisáu', null);
INSERT INTO "public"."paises" VALUES ('272', 'Haití', null);
INSERT INTO "public"."paises" VALUES ('273', 'Honduras', null);
INSERT INTO "public"."paises" VALUES ('274', 'Hungría', null);
INSERT INTO "public"."paises" VALUES ('275', 'India', null);
INSERT INTO "public"."paises" VALUES ('276', 'Indonesia', null);
INSERT INTO "public"."paises" VALUES ('277', 'Irak', null);
INSERT INTO "public"."paises" VALUES ('278', 'Irán', null);
INSERT INTO "public"."paises" VALUES ('279', 'Irlanda', null);
INSERT INTO "public"."paises" VALUES ('280', 'Islandia', null);
INSERT INTO "public"."paises" VALUES ('281', 'Islas Marshall', null);
INSERT INTO "public"."paises" VALUES ('282', 'Islas Salomón', null);
INSERT INTO "public"."paises" VALUES ('283', 'Israel', null);
INSERT INTO "public"."paises" VALUES ('284', 'Italia', null);
INSERT INTO "public"."paises" VALUES ('285', 'Jamaica', null);
INSERT INTO "public"."paises" VALUES ('286', 'Japón', null);
INSERT INTO "public"."paises" VALUES ('287', 'Jordania', null);
INSERT INTO "public"."paises" VALUES ('288', 'Kazajistán', null);
INSERT INTO "public"."paises" VALUES ('289', 'Kenia', null);
INSERT INTO "public"."paises" VALUES ('290', 'Kirguistán', null);
INSERT INTO "public"."paises" VALUES ('291', 'Kiribati', null);
INSERT INTO "public"."paises" VALUES ('292', 'Kuwait', null);
INSERT INTO "public"."paises" VALUES ('293', 'Laos', null);
INSERT INTO "public"."paises" VALUES ('294', 'Lesoto', null);
INSERT INTO "public"."paises" VALUES ('295', 'Letonia', null);
INSERT INTO "public"."paises" VALUES ('296', 'Líbano', null);
INSERT INTO "public"."paises" VALUES ('297', 'Liberia', null);
INSERT INTO "public"."paises" VALUES ('298', 'Libia', null);
INSERT INTO "public"."paises" VALUES ('299', 'Liechtenstein', null);
INSERT INTO "public"."paises" VALUES ('300', 'Lituania', null);
INSERT INTO "public"."paises" VALUES ('301', 'Luxemburgo', null);
INSERT INTO "public"."paises" VALUES ('302', 'Madagascar', null);
INSERT INTO "public"."paises" VALUES ('303', 'Malasia', null);
INSERT INTO "public"."paises" VALUES ('304', 'Malaui', null);
INSERT INTO "public"."paises" VALUES ('305', 'Maldivas', null);
INSERT INTO "public"."paises" VALUES ('306', 'Malí', null);
INSERT INTO "public"."paises" VALUES ('307', 'Malta', null);
INSERT INTO "public"."paises" VALUES ('308', 'Marruecos', null);
INSERT INTO "public"."paises" VALUES ('309', 'Mauricio', null);
INSERT INTO "public"."paises" VALUES ('310', 'Mauritania', null);
INSERT INTO "public"."paises" VALUES ('311', 'México', null);
INSERT INTO "public"."paises" VALUES ('312', 'Micronesia', null);
INSERT INTO "public"."paises" VALUES ('313', 'Moldavia', null);
INSERT INTO "public"."paises" VALUES ('314', 'Mónaco', null);
INSERT INTO "public"."paises" VALUES ('315', 'Mongolia', null);
INSERT INTO "public"."paises" VALUES ('316', 'Montenegro', null);
INSERT INTO "public"."paises" VALUES ('317', 'Mozambique', null);
INSERT INTO "public"."paises" VALUES ('318', 'Namibia', null);
INSERT INTO "public"."paises" VALUES ('319', 'Nauru', null);
INSERT INTO "public"."paises" VALUES ('320', 'Nepal', null);
INSERT INTO "public"."paises" VALUES ('321', 'Nicaragua', null);
INSERT INTO "public"."paises" VALUES ('322', 'Níger', null);
INSERT INTO "public"."paises" VALUES ('323', 'Nigeria', null);
INSERT INTO "public"."paises" VALUES ('324', 'Noruega', null);
INSERT INTO "public"."paises" VALUES ('325', 'Nueva Zelanda', null);
INSERT INTO "public"."paises" VALUES ('326', 'Omán', null);
INSERT INTO "public"."paises" VALUES ('327', 'Países Bajos', null);
INSERT INTO "public"."paises" VALUES ('328', 'Pakistán', null);
INSERT INTO "public"."paises" VALUES ('329', 'Palaos', null);
INSERT INTO "public"."paises" VALUES ('330', 'Panamá', null);
INSERT INTO "public"."paises" VALUES ('331', 'Papúa Nueva Guinea', null);
INSERT INTO "public"."paises" VALUES ('332', 'Paraguay', null);
INSERT INTO "public"."paises" VALUES ('333', 'Perú', null);
INSERT INTO "public"."paises" VALUES ('334', 'Polonia', null);
INSERT INTO "public"."paises" VALUES ('335', 'Portugal', null);
INSERT INTO "public"."paises" VALUES ('336', 'Reino Unido', null);
INSERT INTO "public"."paises" VALUES ('337', 'República Centroafricana', null);
INSERT INTO "public"."paises" VALUES ('338', 'República Checa', null);
INSERT INTO "public"."paises" VALUES ('339', 'República de Macedonia', null);
INSERT INTO "public"."paises" VALUES ('340', 'República del Congo', null);
INSERT INTO "public"."paises" VALUES ('341', 'República Democrática del Congo', null);
INSERT INTO "public"."paises" VALUES ('342', 'República Dominicana', null);
INSERT INTO "public"."paises" VALUES ('343', 'República Sudafricana', null);
INSERT INTO "public"."paises" VALUES ('344', 'Ruanda', null);
INSERT INTO "public"."paises" VALUES ('345', 'Rumanía', null);
INSERT INTO "public"."paises" VALUES ('346', 'Rusia', null);
INSERT INTO "public"."paises" VALUES ('347', 'Samoa', null);
INSERT INTO "public"."paises" VALUES ('348', 'San Cristóbal y Nieves', null);
INSERT INTO "public"."paises" VALUES ('349', 'San Marino', null);
INSERT INTO "public"."paises" VALUES ('350', 'San Vicente y las Granadinas', null);
INSERT INTO "public"."paises" VALUES ('351', 'Santa Lucía', null);
INSERT INTO "public"."paises" VALUES ('352', 'Santo Tomé y Príncipe', null);
INSERT INTO "public"."paises" VALUES ('353', 'Senegal', null);
INSERT INTO "public"."paises" VALUES ('354', 'Serbia', null);
INSERT INTO "public"."paises" VALUES ('355', 'Seychelles', null);
INSERT INTO "public"."paises" VALUES ('356', 'Sierra Leona', null);
INSERT INTO "public"."paises" VALUES ('357', 'Singapur', null);
INSERT INTO "public"."paises" VALUES ('358', 'Siria', null);
INSERT INTO "public"."paises" VALUES ('359', 'Somalia', null);
INSERT INTO "public"."paises" VALUES ('360', 'Sri Lanka', null);
INSERT INTO "public"."paises" VALUES ('361', 'Suazilandia', null);
INSERT INTO "public"."paises" VALUES ('362', 'Sudán', null);
INSERT INTO "public"."paises" VALUES ('363', 'Sudán del Sur', null);
INSERT INTO "public"."paises" VALUES ('364', 'Suecia', null);
INSERT INTO "public"."paises" VALUES ('365', 'Suiza', null);
INSERT INTO "public"."paises" VALUES ('366', 'Surinam', null);
INSERT INTO "public"."paises" VALUES ('367', 'Tailandia', null);
INSERT INTO "public"."paises" VALUES ('368', 'Tanzania', null);
INSERT INTO "public"."paises" VALUES ('369', 'Tayikistán', null);
INSERT INTO "public"."paises" VALUES ('370', 'Timor Oriental', null);
INSERT INTO "public"."paises" VALUES ('371', 'Togo', null);
INSERT INTO "public"."paises" VALUES ('372', 'Tonga', null);
INSERT INTO "public"."paises" VALUES ('373', 'Trinidad y Tobago', null);
INSERT INTO "public"."paises" VALUES ('374', 'Túnez', null);
INSERT INTO "public"."paises" VALUES ('375', 'Turkmenistán', null);
INSERT INTO "public"."paises" VALUES ('376', 'Turquía', null);
INSERT INTO "public"."paises" VALUES ('377', 'Tuvalu', null);
INSERT INTO "public"."paises" VALUES ('378', 'Ucrania', null);
INSERT INTO "public"."paises" VALUES ('379', 'Uganda', null);
INSERT INTO "public"."paises" VALUES ('380', 'Uruguay', null);
INSERT INTO "public"."paises" VALUES ('381', 'Uzbekistán', null);
INSERT INTO "public"."paises" VALUES ('382', 'Vanuatu', null);
INSERT INTO "public"."paises" VALUES ('383', 'Venezuela', null);
INSERT INTO "public"."paises" VALUES ('384', 'Vietnam', null);
INSERT INTO "public"."paises" VALUES ('385', 'Yemen', null);
INSERT INTO "public"."paises" VALUES ('386', 'Yibuti', null);
INSERT INTO "public"."paises" VALUES ('387', 'Zambia', null);
INSERT INTO "public"."paises" VALUES ('388', 'Zimbabue', null);

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
"password" varchar(255) COLLATE "default" NOT NULL,
"ismec" int2 DEFAULT 0 NOT NULL
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
COMMENT ON COLUMN "public"."personal"."ismec" IS 'Campo que define si el usuario es un mecanico 0=SI / 1=SI. en caso de ser mecanico no puede ingresar a la otra plataforma del software.';

-- ----------------------------
-- Records of personal
-- ----------------------------
INSERT INTO "public"."personal" VALUES ('4', 'Sebastian Jorge', 'Guajardo', 'Acevedo', '16438319-9', '1', 'Parinacota #1346', '1', null, 'kanyx', 'b74a5db02b6647bc65522710c6e47e30', '0');
INSERT INTO "public"."personal" VALUES ('5', 'Pilar Constanza ', 'Sáez', 'Contreras', '18261778-4', '1', 'Av. Escondida ', '1', null, 'pilarsaez', '31c7d084f0460fcde98ee9314fc8ef30', '0');
INSERT INTO "public"."personal" VALUES ('6', 'Matías Alonso', 'Aliaga', 'Cortes', '16073376-4', '1', 'xxx', '1', null, 'maliaga', '79d3e1d76a45db2e2737f659dc68f872', '0');
INSERT INTO "public"."personal" VALUES ('7', 'Andres', 'Morales', 'Olmos', '11111111-1', '1', 'xx', '1', null, 'amorales', '827ccb0eea8a706c4c34a16891f84e7b', '0');
INSERT INTO "public"."personal" VALUES ('8', 'Andres', 'Verdejo', 'Iturra', '2222222-2', '1', 'xxx', '1', null, 'averdejo', '7900770abf7086faafd8c122981cc82f', '0');

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
-- Table structure for subestados_ot
-- ----------------------------
DROP TABLE IF EXISTS "public"."subestados_ot";
CREATE TABLE "public"."subestados_ot" (
"id" int8 DEFAULT nextval('subestados_ot_id_seq'::regclass) NOT NULL,
"idestado" int8,
"nestado" varchar(255) COLLATE "default",
"comentarios" text COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of subestados_ot
-- ----------------------------

-- ----------------------------
-- Table structure for tipos_productos
-- ----------------------------
DROP TABLE IF EXISTS "public"."tipos_productos";
CREATE TABLE "public"."tipos_productos" (
"id" int8 DEFAULT nextval('tipos_productos_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"comentario" varchar(255) COLLATE "default",
"iduseradd" int8
)
WITH (OIDS=FALSE)

;
COMMENT ON COLUMN "public"."tipos_productos"."id" IS 'Identificador unico del equipo';
COMMENT ON COLUMN "public"."tipos_productos"."nombre" IS 'nombre del tipo';
COMMENT ON COLUMN "public"."tipos_productos"."comentario" IS 'comentario del tipo';
COMMENT ON COLUMN "public"."tipos_productos"."iduseradd" IS 'Identificador del usuario que agrego el tipo a la base de datos.';

-- ----------------------------
-- Records of tipos_productos
-- ----------------------------
INSERT INTO "public"."tipos_productos" VALUES ('27', 'bomba imp. cerrado', null, '4');
INSERT INTO "public"."tipos_productos" VALUES ('28', 'cuerpo rodamiento', null, '4');
INSERT INTO "public"."tipos_productos" VALUES ('29', 'valvulas', null, '4');

-- ----------------------------
-- View structure for view_comentarios
-- ----------------------------
CREATE OR REPLACE VIEW "public"."view_comentarios" AS 
 SELECT otcomentarios.id,
    otcomentarios.iduser,
    otcomentarios.comentario,
    otcomentarios.idot,
    otcomentarios.fecha,
    otcomentarios.hora,
    personal.id AS personal,
    personal.nombres,
    personal.apellido_p,
    personal.apellido_m
   FROM (otcomentarios
     JOIN personal ON ((otcomentarios.iduser = personal.id)));

-- ----------------------------
-- View structure for view_ot_planificacion
-- ----------------------------
CREATE OR REPLACE VIEW "public"."view_ot_planificacion" AS 
 SELECT ordenestrabajo.id,
    ordenestrabajo.notrabajo,
    ordenestrabajo.nguiadespacho,
    ordenestrabajo.idcliente,
    ordenestrabajo.idtipo,
    ordenestrabajo.idmarca,
    ordenestrabajo.idmodelo,
    ordenestrabajo.nserie,
    ordenestrabajo.prioridad,
    ordenestrabajo.numerocontrato,
    ordenestrabajo.fecha_ingreso,
    ordenestrabajo.nseriefabricante,
    ordenestrabajo.fecha_cierre,
    ordenestrabajo.idestado,
    ordenestrabajo.tipo,
    ordenestrabajo.noc,
    ordenestrabajo.nagendamiento,
    ordenestrabajo.idrespingreso,
    ordenestrabajo.tag,
    ordenestrabajo.ingrepaid,
    ordenestrabajo.idmechanicstation,
    tipos_productos.id AS tipoid,
    tipos_productos.nombre AS tiponombre,
    marcas.id AS marcaid,
    marcas.nombre AS marcanombre,
    modelos.id AS modeloid,
    modelos.nombre AS modelonombre,
    estados_ot.id AS estadoid,
    estados_ot.nestado AS estadonombre
   FROM ((((ordenestrabajo
     JOIN tipos_productos ON ((ordenestrabajo.idtipo = tipos_productos.id)))
     JOIN marcas ON ((ordenestrabajo.idmarca = marcas.id)))
     JOIN modelos ON ((ordenestrabajo.idmodelo = modelos.id)))
     JOIN estados_ot ON ((ordenestrabajo.idestado = estados_ot.id)));

-- ----------------------------
-- View structure for view_rel_productos
-- ----------------------------
CREATE OR REPLACE VIEW "public"."view_rel_productos" AS 
 SELECT tipos_productos.id,
    tipos_productos.nombre,
    marcas.nombre AS marcanombre,
    marcas.idtipo,
    modelos.idmarca,
    marcas.id AS marcaid,
    modelos.nombre AS modelonombre,
    modelos.id AS modeloid
   FROM ((tipos_productos
     JOIN marcas ON ((tipos_productos.id = marcas.idtipo)))
     JOIN modelos ON ((modelos.idmarca = marcas.id)));

-- ----------------------------
-- View structure for vista_lista_mechstation
-- ----------------------------
CREATE OR REPLACE VIEW "public"."vista_lista_mechstation" AS 
 SELECT ordenestrabajo.id,
    ordenestrabajo.notrabajo,
    ordenestrabajo.fecha_ingreso,
    ordenestrabajo.idmechanicstation,
    ordenestrabajo.idtipo,
    ordenestrabajo.idmarca,
    ordenestrabajo.idmodelo,
    tipos_productos.id AS tipoid,
    tipos_productos.nombre AS nombretipo,
    marcas.id AS marcaid,
    marcas.nombre AS nombremarca,
    modelos.id AS modeloid,
    modelos.nombre AS nombremodelo,
    ordenestrabajo.idestado,
    estados_ot.id AS estsadoid,
    estados_ot.nestado AS estadonombre
   FROM ((((ordenestrabajo
     JOIN tipos_productos ON ((ordenestrabajo.idtipo = tipos_productos.id)))
     JOIN marcas ON ((ordenestrabajo.idmarca = marcas.id)))
     JOIN modelos ON ((ordenestrabajo.idmodelo = modelos.id)))
     JOIN estados_ot ON ((ordenestrabajo.idestado = estados_ot.id)));

-- ----------------------------
-- View structure for vista_otreporte
-- ----------------------------
CREATE OR REPLACE VIEW "public"."vista_otreporte" AS 
 SELECT ordenestrabajo.id,
    ordenestrabajo.notrabajo,
    ordenestrabajo.nguiadespacho,
    ordenestrabajo.idcliente,
    ordenestrabajo.idtipo,
    ordenestrabajo.idmarca,
    ordenestrabajo.idmodelo,
    ordenestrabajo.nserie,
    ordenestrabajo.prioridad,
    ordenestrabajo.numerocontrato,
    ordenestrabajo.fecha_ingreso,
    ordenestrabajo.nseriefabricante,
    ordenestrabajo.fecha_cierre,
    ordenestrabajo.idestado,
    ordenestrabajo.tipo,
    ordenestrabajo.noc,
    ordenestrabajo.nagendamiento,
    ordenestrabajo.idrespingreso,
    personal.nombres,
    personal.apellido_p,
    personal.apellido_m,
    personal.id AS personalid,
    clientes.id AS clienteid,
    clientes.razonsocial,
    clientes.rut,
    tipos_productos.id AS tipoid,
    tipos_productos.nombre AS nombretipo,
    marcas.id AS marcaid,
    marcas.nombre AS nombremarca,
    modelos.id AS modeloid,
    modelos.nombre AS nombremodelo,
    estados_ot.id AS estadoid,
    estados_ot.nestado,
    clientes.dempresa,
    ordenestrabajo.tag,
    ordenestrabajo.ingrepaid,
    ingrepar.id AS ingerid,
    ingrepar.nombre AS ingernombre
   FROM (((((((ordenestrabajo
     JOIN personal ON ((ordenestrabajo.idrespingreso = personal.id)))
     JOIN clientes ON ((ordenestrabajo.idcliente = clientes.id)))
     JOIN tipos_productos ON ((ordenestrabajo.idtipo = tipos_productos.id)))
     JOIN marcas ON ((ordenestrabajo.idmarca = marcas.id)))
     JOIN modelos ON ((ordenestrabajo.idmodelo = modelos.id)))
     JOIN estados_ot ON ((ordenestrabajo.idestado = estados_ot.id)))
     JOIN ingrepar ON ((ordenestrabajo.ingrepaid = ingrepar.id)));

-- ----------------------------
-- Alter Sequences Owned By 
-- ----------------------------
ALTER SEQUENCE "public"."ciudades_id_seq" OWNED BY "ciudades"."id";
ALTER SEQUENCE "public"."clientes_id_seq" OWNED BY "clientes"."id";
ALTER SEQUENCE "public"."estacionesmecanicas_id_seq" OWNED BY "estacionesmecanicas"."id";
ALTER SEQUENCE "public"."estados_id_seq" OWNED BY "estados_ot"."id";
ALTER SEQUENCE "public"."flex_ots_id_seq" OWNED BY "flex_ots"."id";
ALTER SEQUENCE "public"."ingrepar_id_seq" OWNED BY "ingrepar"."id";
ALTER SEQUENCE "public"."marca_id_seq" OWNED BY "marcas"."id";
ALTER SEQUENCE "public"."med_componentes_id_seq" OWNED BY "med_componentes"."id";
ALTER SEQUENCE "public"."med_ots_id_seq" OWNED BY "med_ots"."id";
ALTER SEQUENCE "public"."med_parametros_id_seq" OWNED BY "med_parametros"."id";
ALTER SEQUENCE "public"."modelos_id_seq" OWNED BY "modelos"."id";
ALTER SEQUENCE "public"."ot_id_seq" OWNED BY "ordenestrabajo"."id";
ALTER SEQUENCE "public"."ot_inspvisual_id_seq" OWNED BY "ot_inspvisual"."id";
ALTER SEQUENCE "public"."otcomentarios_id_seq" OWNED BY "otcomentarios"."id";
ALTER SEQUENCE "public"."otimages_id_seq" OWNED BY "otimages"."id";
ALTER SEQUENCE "public"."paises_id_seq" OWNED BY "paises"."id";
ALTER SEQUENCE "public"."personal_id_seq" OWNED BY "personal"."id";
ALTER SEQUENCE "public"."subestados_ot_id_seq" OWNED BY "subestados_ot"."id";
ALTER SEQUENCE "public"."tipos_productos_id_seq" OWNED BY "tipos_productos"."id";

-- ----------------------------
-- Primary Key structure for table equipo
-- ----------------------------
ALTER TABLE "public"."equipo" ADD PRIMARY KEY ("id", "ot");

-- ----------------------------
-- Primary Key structure for table flex_ots
-- ----------------------------
ALTER TABLE "public"."flex_ots" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table marcas
-- ----------------------------
ALTER TABLE "public"."marcas" ADD PRIMARY KEY ("id", "nombre");

-- ----------------------------
-- Primary Key structure for table med_componentes
-- ----------------------------
ALTER TABLE "public"."med_componentes" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table med_ots
-- ----------------------------
ALTER TABLE "public"."med_ots" ADD PRIMARY KEY ("id", "idcomponente");

-- ----------------------------
-- Primary Key structure for table med_parametros
-- ----------------------------
ALTER TABLE "public"."med_parametros" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table ordenestrabajo
-- ----------------------------
ALTER TABLE "public"."ordenestrabajo" ADD PRIMARY KEY ("id", "notrabajo");

-- ----------------------------
-- Primary Key structure for table ot_inspvisual
-- ----------------------------
ALTER TABLE "public"."ot_inspvisual" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table otimages
-- ----------------------------
ALTER TABLE "public"."otimages" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table personal
-- ----------------------------
ALTER TABLE "public"."personal" ADD PRIMARY KEY ("id", "rut");
