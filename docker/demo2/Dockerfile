FROM ubuntu:20.04 AS build
RUN apt-get update && apt-get install -y build-essential
WORKDIR /app
COPY src/hello.c /app/
RUN gcc -o hello -static hello.c

FROM scratch AS final
WORKDIR /app/
COPY --from=build /app/hello ./
ENTRYPOINT ["/app/hello"]