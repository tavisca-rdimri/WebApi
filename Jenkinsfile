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

         
    }
}
