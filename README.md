# set-git-date
一个小工具修改环境变量，已达到修改git提交时间的功能
```powershell
$Env:GIT_COMMITTER_DATE="2022-1-1 0:55"
$Env:GIT_AUTHOR_DATE ="2022-1-1 0:55"
```

# 用法
```
//定时更新为8小时前
sgd -8 
```
