Benchmarking WCF Service Host
================================

Aidan Casey September 2012

A  test rig to bench mark the performance of a WCF service hosted as a console app versus a Windows Service

The results – 

Migrate 500 clients sequentially using console app as WCF host			1641 seconds
Migrate 500 clients sequentially using windows service as WCF host		350 seconds		
Migrate 500 clients in parallel (threadpool) using windows service    	196 seconds	

To set up
*********
Run the file  created.sql to create the database

To install the windows service 
******************************
browse to the release folder 
installutil service.exe

To uninstall the service
******************************
browse to the release folder
installutil /u service.exe


to start / stop service
************************
net start MYOBDataMigration
net stop MYOBDataMigration



