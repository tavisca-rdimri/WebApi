pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                bat 'dotnet build WebApi.sln -p:Configuration=release -v:q'
            
                bat 'echo deleted workspace'
            }
        }

        stage('test') {
            steps {
                bat 'echo test'
                bat 'dotnet test XUnitTestProject1/XUnitTestProject1.csproj -p:Configiration=release -v:q'
            }
        }
        stage('Publish') {
        	
        	steps{
        		bat 'dotnet publish'
        	}
        }

          stage('deploy') {
            steps {
                bat 'dotnet WebApi/bin/Release/netcoreapp2.2/WebApi.dll'
            }
        }
    }
    
}
