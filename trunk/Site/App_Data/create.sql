SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

CREATE SCHEMA IF NOT EXISTS `freddacaixa` ;
USE `freddacaixa` ;

-- -----------------------------------------------------
-- Table `freddacaixa`.`Usuario`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `freddacaixa`.`Usuario` (
  `ID` INT NOT NULL AUTO_INCREMENT ,
  `Login` VARCHAR(100) NOT NULL ,
  `Senha` VARCHAR(100) NOT NULL ,
  PRIMARY KEY (`ID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `freddacaixa`.`Index`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `freddacaixa`.`Index` (
  `ID` INT NOT NULL AUTO_INCREMENT ,
  `Titulo` VARCHAR(8000) NULL ,
  `SubTitulo` VARCHAR(8000) NULL ,
  `Corpo` VARCHAR(10000) NULL ,
  PRIMARY KEY (`ID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `freddacaixa`.`Proposta`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `freddacaixa`.`Proposta` (
  `ID` INT NOT NULL AUTO_INCREMENT ,
  `Titulo` VARCHAR(8000) NULL ,
  `SubTitulo` VARCHAR(8000) NULL ,
  `Corpo` VARCHAR(10000) NULL ,
  PRIMARY KEY (`ID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `freddacaixa`.`Galeria`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `freddacaixa`.`Galeria` (
  `ID` INT NOT NULL AUTO_INCREMENT ,
  `ImagemUrl` VARCHAR(8000) NULL ,
  `Legenda` VARCHAR(8000) NULL ,
  `Titulo` VARCHAR(8000) NULL ,
  PRIMARY KEY (`ID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `freddacaixa`.`Foto`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `freddacaixa`.`Foto` (
  `ID` INT NOT NULL AUTO_INCREMENT ,
  `Legenda` VARCHAR(8000) NULL ,
  `ImagemUrl` VARCHAR(8000) NULL ,
  `GaleriaID` INT NOT NULL ,
  `Titulo` VARCHAR(8000) NULL ,
  PRIMARY KEY (`ID`) ,
  INDEX `fk_Foto_Galeria` (`GaleriaID` ASC) ,
  CONSTRAINT `fk_Foto_Galeria`
    FOREIGN KEY (`GaleriaID` )
    REFERENCES `freddacaixa`.`Galeria` (`ID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
