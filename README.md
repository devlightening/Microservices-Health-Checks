# Microservices Health Checks Project

This project demonstrates how to implement **health checks and monitoring** for microservices using **.NET 8**, **HealthChecks.UI**, and databases such as **Redis**, **PostgreSQL**, **MSSQL**, and **MongoDb**.  
The goal is to build resilient microservices that expose `/health` endpoints and are monitored via a central **Monitoring Service** with a user-friendly dashboard.

---

## 🚀 Features

- Microservices with individual health check endpoints:
  - `ServiceA`  
  - `ServiceB`  
- **MonitoringService** with HealthChecksUI for centralized monitoring.
- Health checks for:
  - **Redis**  
  - **PostgreSQL**  
  - **MSSQL**  
  - **MongoDB** (optional)
- Custom UI theme with logo and colors.
- Visualization of **healthy/unhealthy** states in the HealthChecksUI dashboard.

---

## 🛠️ Technologies

- **.NET 8** (ASP.NET Core Web API)  
- **HealthChecks.UI**  
- **Redis**  
- **PostgreSQL**  
- **MSSQL**  
- **Docker** (optional for containerized setup)

---

## 📸 Screenshots & Scenarios

### 1. Redis stopped
When Redis service is stopped, the health check fails:


<img width="1552" height="637" alt="RedisStopped" src="https://github.com/user-attachments/assets/d1898917-9386-4a1e-a295-19c5e2384bc1" />

In the HealthChecksUI dashboard, the failure is also displayed:

<img width="1892" height="525" alt="RedisStoppedHealthUI" src="https://github.com/user-attachments/assets/b58dad33-3b26-4a1e-a0f3-d81eeea9fa8f" />

---

### 2. Redis restarted
After Redis is restarted, it is automatically detected as healthy again and shown in the **Database Failures Table**:

<img width="545" height="312" alt="Redis Restarted and Displayed in Database Failures Table" src="https://github.com/user-attachments/assets/7a7ceaf1-ab42-412b-8ffa-47bfffcc223b" />


When Redis is stopped, it also appears in the failure table:

<img width="543" height="258" alt="Redis Stopped and its display in the Database Failures Table" src="https://github.com/user-attachments/assets/15dd0167-3597-42a4-aa2f-b76df5c0e20c" />


---

### 3. PostgreSQL stopped
If PostgreSQL is unavailable, the microservice health check reports it as **Unhealthy**:

<img width="1606" height="698" alt="PostgreSqlStopped" src="https://github.com/user-attachments/assets/bb1e54bb-130c-4abd-9900-ea24004c7fe2" />


This is also reflected in the Monitoring UI:

<img width="1883" height="460" alt="PostgreSqlStoppedHealthUI" src="https://github.com/user-attachments/assets/5338d7cb-fbac-46ec-bee6-8a125c754673" />


---

### 4. MSSQL database health check
The HealthChecksUI also monitors MSSQL connections and reports failures or healthy status:

<img width="370" height="290" alt="MSSQLDataBase" src="https://github.com/user-attachments/assets/bb125461-e8f1-4d7c-a9c4-5f9d70028c61" />


---

### 5. Redis execution history
The UI provides detailed execution entries and history for Redis health checks:

<img width="960" height="576" alt="Health Check Execution Entries   Histories For Redis" src="https://github.com/user-attachments/assets/7332ff21-8028-409f-acdb-d543da5d72c3" />


---

## 🔍 How It Works

1. Each microservice exposes a `/health` endpoint.  
2. The MonitoringService collects health check data from microservices.  
3. Results are displayed in the **HealthChecksUI dashboard**.  
4. Failures are logged in a **Database Failures Table**, with automatic recovery detection.  

---

## 📦 Running the Project

- Run the services locally (`dotnet run`) or with **Docker Compose**.  
- Access the health endpoints:  
  - `http://localhost:7092/health` → ServiceA  
  - `http://localhost:7127/health` → ServiceB  
- Access the monitoring dashboard:  
  - `http://localhost:7039/health-ui`  

---

## ✅ Conclusion

This project shows how to **monitor distributed services** in real time, identify unhealthy dependencies (databases, caches), and display their status in a clear dashboard.  
It demonstrates failure scenarios (stopping Redis/PostgreSQL) and recovery (restarting services) with full UI integration.
