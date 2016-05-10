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

Date: 2016-05-10 11:44:00
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
-- Sequence structure for estados_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."estados_id_seq";
CREATE SEQUENCE "public"."estados_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 11
 CACHE 1;
SELECT setval('"public"."estados_id_seq"', 11, true);

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
-- Sequence structure for modelos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."modelos_id_seq";
CREATE SEQUENCE "public"."modelos_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 142
 CACHE 1;
SELECT setval('"public"."modelos_id_seq"', 142, true);

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
-- Sequence structure for tipos_productos_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."tipos_productos_id_seq";
CREATE SEQUENCE "public"."tipos_productos_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 28
 CACHE 1;
SELECT setval('"public"."tipos_productos_id_seq"', 28, true);

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
INSERT INTO "public"."estados_ot" VALUES ('6', 'En Proceso', null);
INSERT INTO "public"."estados_ot" VALUES ('7', 'Proximo Despacho', null);
INSERT INTO "public"."estados_ot" VALUES ('8', 'Cerrada OT', null);

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
"idrespingreso" varchar(255) COLLATE "default",
"nserie" varchar(255) COLLATE "default",
"prioridad" varchar(255) COLLATE "default" NOT NULL,
"numerocontrato" varchar(255) COLLATE "default",
"fecha_ingreso" date,
"nseriefat" varchar(255) COLLATE "default",
"fecha_cierre" date,
"idestados" int8
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
INSERT INTO "public"."tipos_productos" VALUES ('27', 'bomba', null, '4');
INSERT INTO "public"."tipos_productos" VALUES ('28', 'cpo rod', null, '4');

-- ----------------------------
-- Alter Sequences Owned By 
-- ----------------------------
ALTER SEQUENCE "public"."clientes_id_seq" OWNED BY "clientes"."id";
ALTER SEQUENCE "public"."estados_id_seq" OWNED BY "estados_ot"."id";
ALTER SEQUENCE "public"."marca_id_seq" OWNED BY "marcas"."id";
ALTER SEQUENCE "public"."modelos_id_seq" OWNED BY "modelos"."id";
ALTER SEQUENCE "public"."ot_id_seq" OWNED BY "ordenestrabajo"."id";
ALTER SEQUENCE "public"."paises_id_seq" OWNED BY "paises"."id";
ALTER SEQUENCE "public"."personal_id_seq" OWNED BY "personal"."id";
ALTER SEQUENCE "public"."tipos_productos_id_seq" OWNED BY "tipos_productos"."id";

-- ----------------------------
-- Primary Key structure for table equipo
-- ----------------------------
ALTER TABLE "public"."equipo" ADD PRIMARY KEY ("id", "ot");

-- ----------------------------
-- Primary Key structure for table marcas
-- ----------------------------
ALTER TABLE "public"."marcas" ADD PRIMARY KEY ("id", "nombre");

-- ----------------------------
-- Primary Key structure for table ordenestrabajo
-- ----------------------------
ALTER TABLE "public"."ordenestrabajo" ADD PRIMARY KEY ("id", "not");

-- ----------------------------
-- Primary Key structure for table personal
-- ----------------------------
ALTER TABLE "public"."personal" ADD PRIMARY KEY ("id", "rut");
