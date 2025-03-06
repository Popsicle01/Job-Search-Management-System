CREATE DATABASE jobsearch_db;
USE jobsearch_db;

CREATE TABLE Jobs (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    location VARCHAR(255) NOT NULL,
    level ENUM('Entry', 'Mid', 'Senior') NOT NULL,
    description TEXT NOT NULL
);

CREATE TABLE Applications (
    id INT AUTO_INCREMENT PRIMARY KEY,
    job_id INT,
    applicant_name VARCHAR(255) NOT NULL,
    applicant_email VARCHAR(255) NOT NULL,
    FOREIGN KEY (job_id) REFERENCES Jobs(id) ON DELETE CASCADE
);
