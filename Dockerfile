FROM microsoft/dotnet

# Args / Env
ARG repositoryUrl=https://github.com/psantiago32/jaca-web.git
ARG configuration=Release
ARG distFolder=Jaca.Api/bin/Release/netcoreapp1.1
ARG apiPort=5000
ARG appFile=Jaca.Api

# Change to temp workspace
WORKDIR /temp

# Get code from repository
RUN git clone ${repositoryUrl} .

# Restore packages and publish app
WORKDIR /jaca-web
RUN dotnet restore
RUN dotnet publish -c ${configuration}

# Copy files to /app
RUN mv /temp/${distFolder} /app
 
# Expose port for the Web API traffic
ENV ASPNETCORE_URLS http://+:${apiPort}
EXPOSE ${apiPort}

# Clear temp files
RUN rm -rf /temp 

# Run application
WORKDIR /app
ENV appFile=$appFile
ENTRYPOINT dotnet $appFile