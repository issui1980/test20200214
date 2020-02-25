FROM ubuntu:18.10

LABEL maintainer="oshimamasara@gmail.com"
LABEL version="1.0"
LABEL description="Dockerfileのテスト、Apacheサーバー"

RUN apt-get update
RUN apt-get install -y apache2

CMD ["apachectl", "-D", "FOREGROUND"]