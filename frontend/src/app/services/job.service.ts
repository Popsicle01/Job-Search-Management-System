import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class JobService {
  private apiUrl = 'http://localhost:5000/api/jobs';

  constructor(private http: HttpClient) {}

  getJobs(title?: string, location?: string, level?: string): Observable<any> {
    let queryParams = `?title=${title || ''}&location=${location || ''}&level=${level || ''}`;
    return this.http.get(`${this.apiUrl}${queryParams}`);
  }

  applyForJob(jobId: number, applicantName: string, applicantEmail: string): Observable<any> {
    return this.http.post(`${this.apiUrl}/apply`, { jobId, applicantName, applicantEmail });
  }
}
