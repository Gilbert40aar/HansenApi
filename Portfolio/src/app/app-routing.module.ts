import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { AdmineducationComponent } from './admin/admineducation/admineducation.component';
import { CreateeducationComponent } from './admin/admineducation/createeducation/createeducation.component';
import { EditeducationComponent } from './admin/admineducation/editeducation/editeducation.component';
import { AdminprofileComponent } from './admin/adminprofile/adminprofile.component';
import { CreateprofileComponent } from './admin/adminprofile/createprofile/createprofile.component';
import { EditprofileComponent } from './admin/adminprofile/editprofile/editprofile.component';
import { ProfilecontactComponent } from './admin/adminprofile/profilecontact/profilecontact.component';
import { ProfilelocationComponent } from './admin/adminprofile/profilelocation/profilelocation.component';
import { ProfilestatusComponent } from './admin/adminprofile/profilestatus/profilestatus.component';
import { AddprojectComponent } from './admin/adminproject/addproject/addproject.component';
import { AdminprojectComponent } from './admin/adminproject/adminproject.component';
import { EditprojectComponent } from './admin/adminproject/editproject/editproject.component';
import { AdminskillsComponent } from './admin/adminskills/adminskills.component';
import { CreateskillsComponent } from './admin/adminskills/createskills/createskills.component';
import { CsharpComponent } from './admin/adminskills/createskills/csharp/csharp.component';
import { CreateskillsgenreComponent } from './admin/adminskills/createskillsgenre/createskillsgenre.component';
import { EditskillsComponent } from './admin/adminskills/editskills/editskills.component';
import { AdminworkComponent } from './admin/adminwork/adminwork.component';
import { CreateworkComponent } from './admin/adminwork/creatework/creatework.component';
import { EditworkComponent } from './admin/adminwork/editwork/editwork.component';
import { DashboardComponent } from './admin/dashboard/dashboard.component';
import { CreatesettingsComponent } from './admin/settings/createsettings/createsettings.component';
import { EditsettingsComponent } from './admin/settings/editsettings/editsettings.component';
import { SettingsComponent } from './admin/settings/settings.component';
import { AboutComponent } from './home/about/about.component';
import { ContactComponent } from './home/contact/contact.component';
import { FrontpageComponent } from './home/frontpage/frontpage.component';
import { HomeComponent } from './home/home.component';
import { ResumeComponent } from './home/resume/resume.component';
import { WorksComponent } from './home/works/works.component';
import { LoginComponent } from './login/login.component';
import { SetupComponent } from './setup/setup.component';

const routes: Routes = [
  {path: '', pathMatch: 'full', redirectTo: 'home/frontpage'},
  {path: 'home', component: HomeComponent, children: [
    {path: 'frontpage', component: FrontpageComponent},
    {path: 'about', component: AboutComponent},
    {path: 'resume', component: ResumeComponent},
    {path: 'works', component: WorksComponent},
    {path: 'contact', component: ContactComponent}
  ]},
  {path: 'login', component: LoginComponent},
  {path: 'setup', component: SetupComponent},
  {path: 'admin', component: AdminComponent, children: [
    {path: 'dashboard', component: DashboardComponent},
    {path: 'profile', component: AdminprofileComponent},
    {path: 'location', component: ProfilelocationComponent},
    {path: 'status', component: ProfilestatusComponent},
    {path: 'contact', component: ProfilecontactComponent},
    {path: 'work', component: AdminworkComponent},
    {path: 'addWork', component: CreateworkComponent},
    {path: 'editWork', component: EditworkComponent},
    {path: 'education', component: AdmineducationComponent},
    {path: 'addEducation', component: CreateeducationComponent},
    {path: 'editEducation', component: EditeducationComponent},
    {path: 'skills', component: AdminskillsComponent},
    {path: 'createSkill', component: CreateskillsComponent},
    {path: 'createSkillGenre', component: CreateskillsgenreComponent},
    {path: 'editSkill', component: EditskillsComponent},
    {path: 'createprofile', component: CreateprofileComponent},
    {path: 'editprofile', component: EditprofileComponent},
    {path: 'projects', component: AdminprojectComponent},
    {path: 'addprojects', component: AddprojectComponent},
    {path: 'editprojects', component: EditprojectComponent},
    {path: 'settings', component: SettingsComponent},
    {path: 'createSettings', component: CreatesettingsComponent},
    {path: 'editSettings', component: EditsettingsComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
