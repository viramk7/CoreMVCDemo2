ALTER TABLE `Student` DROP COLUMN `Age`;

ALTER TABLE `Student` CHANGE `Address` `Address2` longtext NULL
INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181005063550_IM3', '2.1.0-rtm-30799');

