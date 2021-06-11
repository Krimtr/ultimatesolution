pipeline {
    agent any
    environment
    {
        dotnet ='C:\\"Program Files"\\dotnet\\dotnet.exe'
    }
    stages {
        stage('Build') {
            steps {
                bat 'C:\\"Program Files"\\dotnet\\dotnet.exe build'
            }
        }
        stage('Run') {
            steps {
                bat 'dotnet run'
            }
        }
        stage('Clean') {
            steps {
                bat 'dotnet clean'
            }
        }
    }
}