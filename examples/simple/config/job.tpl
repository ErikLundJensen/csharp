apiVersion: batch/v1
kind: Job
metadata:
  name: job-123
spec:
  ttlSecondsAfterFinished: 600
  template:
    spec:
      containers:
      - name: job
        image: somewhere/containerimage:0.0.1
      restartPolicy: Never
  backoffLimit: 2