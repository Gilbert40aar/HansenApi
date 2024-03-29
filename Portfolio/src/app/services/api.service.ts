import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IAdmin } from '../interfaces/iadmin';
import { IContact } from '../interfaces/icontact';
import { IEducation } from '../interfaces/ieducation';
import { ILocation } from '../interfaces/ilocation';
import { ILogin } from '../interfaces/ilogin';
import { IMessage } from '../interfaces/imessage';
import { IProfile } from '../interfaces/iprofile';
import { IProjects } from '../interfaces/iprojects';
import { ISetting } from '../interfaces/isetting';
import { ISkillGenre } from '../interfaces/iskill-genre';
import { IStatus } from '../interfaces/istatus';
import { IToken } from '../interfaces/itoken';
import { IWork } from '../interfaces/iwork';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  baseUrl = "https://localhost:44376/api/";

  /* Post data into the database */

  saveAdmin(data: IAdmin): Observable<IAdmin> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post<IAdmin>(this.baseUrl + 'Admins/CreateAdmin', body, {headers: headers});
  }

  saveMessage(data: IMessage): Observable<IMessage> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post<IMessage>(this.baseUrl + 'Messages/CreateMessage', body, {headers: headers});
  }

  saveProfile(data: IProfile): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post(this.baseUrl + 'Profiles/CreateProfile', body, {headers: headers});
  }

  saveLocation(data: ILocation): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post(this.baseUrl + 'Locations/CreateLocation', body, {headers: headers});
  }

  saveStatus(data: IStatus): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post(this.baseUrl + 'Status/CreateStatus', body, {headers: headers});
  }

  saveWork(data: IWork): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post(this.baseUrl + 'Works/CreateWork', body, {headers: headers});
  }

  saveContact(data: IContact): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post(this.baseUrl + 'Contacts/CreateContact', body, {headers: headers});
  }

  saveEducation(data: IEducation): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post(this.baseUrl + 'Educations/CreateEducation', body, {headers: headers});
  }

  saveSkills(data: ISkillGenre): Observable<ISkillGenre> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.post<ISkillGenre>(this.baseUrl + 'Skills/CreateSkills', body, {headers: headers});
  }

  /* Updating data in database */
  updateProfile(data: IProfile): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Profiles/UpdateProfile/' + data.profileId, body, {headers: headers});
  }

  updateContact(data: IContact): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Contacts/UpdateContacts/' + data.contactId, body, {headers: headers});
  }

  updateEducation(data: IEducation): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Educations/UpdateEducations/' + data.educationId, body, {headers: headers});
  }

  updateLocation(data: ILocation): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Locations/UpdateLocations/' + data.locationId, body, {headers: headers});
  }

  updateProject(data: IProjects): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Projects/UpdateProjects/' + data.projectId, body, {headers: headers});
  }

  updateSkill(data: ISkillGenre): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Skills/UpdateSkills/' + data.skillsId, body, {headers: headers});
  }

  updateStatus(data: IStatus): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Status/UpdateStatus/' + data.statusId, body, {headers: headers});
  }

  updateWork(data: IWork): Observable<Object> {
    const body = JSON.stringify(data);
    let headers = new HttpHeaders({
      'Content-Type': 'application/json; charset=UTF-8'
    });
    return this.http.put(this.baseUrl + 'Works/UpdateWork/' + data.workId, body, {headers: headers});
  }

  /* Getting data from the database */
  getLocationData(): Observable<ILocation[]> {
    return this.http.get<ILocation[]>(this.baseUrl + 'Locations/GetAllLocations');
  }

  getStatusData(): Observable<IStatus[]> {
    return this.http.get<IStatus[]>(this.baseUrl + 'Status/GetAllStatus');
  }

  getContactData(): Observable<IContact[]> {
    return this.http.get<IContact[]>(this.baseUrl + 'Contacts/GetAllContacts');
  }

  getProfileData(): Observable<IProfile[]> {
    return this.http.get<IProfile[]>(this.baseUrl + 'Profiles/GetAllProfiles');
  }

  getSettings(): Observable<ISetting[]> {
    return this.http.get<ISetting[]>(this.baseUrl + 'Settings/GetAllSettings');
  }

  /* Get single objects */

  getSingleProfileData(id: any): Observable<IProfile> {
    return this.http.get<IProfile>(this.baseUrl + 'Profiles/' + id);
  }

  getMyProfileData(): Observable<IProfile> {
    return this.http.get<IProfile>(this.baseUrl + 'Profiles/MyProfile');
  }

  getProfileCount(): Observable<IProfile[]> {
    return this.http.get<IProfile[]>(this.baseUrl + 'Profiles/GetAllProfiles');
  }

  getWorkData(): Observable<IWork[]> {
    return this.http.get<IWork[]>(this.baseUrl + 'Works/GetAllWork');
  }

  getSingleWorkData(id: any):Observable<IWork> {
    return this.http.get<IWork>(this.baseUrl + 'Works/' + id);
  }

  getEducationData(): Observable<IEducation[]> {
    return this.http.get<IEducation[]>(this.baseUrl + 'Educations/GetAllEducations');
  }

  getSingleEducationData(id: any): Observable<IEducation> {
    return this.http.get<IEducation>(this.baseUrl + 'Educations/' + id);
  }

  getAllSkills(): Observable<ISkillGenre[]> {
    return this.http.get<ISkillGenre[]>(this.baseUrl + 'Skills/GetAllSkills');
  }
  getSingleSkillData(id :any): Observable<ISkillGenre> {
    return this.http.get<ISkillGenre>(this.baseUrl + 'Skills/' +id);
  }

  /* Delete data from database goes here */
  deletework(id: any): Observable<IWork> {
    return this.http.delete<IWork>(this.baseUrl + 'Works/DeleteWork/' + id);
  }

  deleteEducation(id: any): Observable<IEducation> {
    return this.http.delete<IEducation>(this.baseUrl + 'Educations/DeleteEducation/' + id);
  }

  deleteSkill(id: any): Observable<ISkillGenre> {
    return this.http.delete<ISkillGenre>(this.baseUrl + 'Skills/DeleteSkills/' + id);
  }

  /* Getting data for the login */

  login(data: ILogin): Observable<IToken> {
    return this.http.get<IToken>(this.baseUrl + 'Admins/AdminLogin/'+data.username+'/'+data.password);
  }

}
