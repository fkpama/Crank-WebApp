@echo OFF
setlocal
set sql="Data Source=localhost;Initial Catalog=Crank;User=sa;Password=yourStrong(!)Password;Encrypt=false"
set table=Benchmarks
set jsonFile=result.json
crank -c %~dp0\api.benchmarks.yml --profile local --scenario %*
rem crank -c %~dp0\api.benchmarks.yml --profile local --sql %sql% --table %table% --json %jsonFile%  --scenario %*

