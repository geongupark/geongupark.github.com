#!/bin/bash

for arg in "$@";do
	args="${args} ${arg}"
done
args="$(date +%Y%m%d), ""${args}"

git add . && git commit -m "${args}" && git push
