import { Component, OnInit } from '@angular/core';
import { JobService } from '../../services/job.service';

@Component({
  selector: 'app-job-list',
  templateUrl: './job-list.component.html',
  styleUrls: ['./job-list.component.css'],
})
export class JobListComponent implements OnInit {
  jobs: any[] = [];
  title = '';
  location = '';
  level = '';

  constructor(private jobService: JobService) {}

  ngOnInit(): void {
    this.searchJobs();
  }

  searchJobs(): void {
    this.jobService.getJobs(this.title, this.location, this.level).subscribe((data) => {
      this.jobs = data;
    });
  }

  apply(jobId: number): void {
    const applicantName = prompt('Enter your name:');
    const applicantEmail = prompt('Enter your email:');
    
    if (applicantName && applicantEmail) {
      this.jobService.applyForJob(jobId, applicantName, applicantEmail).subscribe((response) => {
        alert(response.message);
      });
    }
  }
}
