import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminComponent } from './admin/admin.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './home/header/header.component';
import { FooterComponent } from './home/footer/footer.component';
import { LoginComponent } from './login/login.component';
import { SetupComponent } from './setup/setup.component';
import { AdminheaderComponent } from './admin/adminheader/adminheader.component';
import { AdminfooterComponent } from './admin/adminfooter/adminfooter.component';
import { AdminsidebarComponent } from './admin/adminsidebar/adminsidebar.component';
import { DashboardComponent } from './admin/dashboard/dashboard.component';
import { AdminprofileComponent } from './admin/adminprofile/adminprofile.component';
import { ProfilelocationComponent } from './admin/adminprofile/profilelocation/profilelocation.component';
import { ProfilestatusComponent } from './admin/adminprofile/profilestatus/profilestatus.component';
import { ProfilecontactComponent } from './admin/adminprofile/profilecontact/profilecontact.component';
import { AdminworkComponent } from './admin/adminwork/adminwork.component';
import { CreateworkComponent } from './admin/adminwork/creatework/creatework.component';
import { EditworkComponent } from './admin/adminwork/editwork/editwork.component';
import { AdmineducationComponent } from './admin/admineducation/admineducation.component';
import { CreateeducationComponent } from './admin/admineducation/createeducation/createeducation.component';
import { EditeducationComponent } from './admin/admineducation/editeducation/editeducation.component';
import { AdminskillsComponent } from './admin/adminskills/adminskills.component';
import { CreateskillsComponent } from './admin/adminskills/createskills/createskills.component';
import { CreateskillsgenreComponent } from './admin/adminskills/createskillsgenre/createskillsgenre.component';
import { EditskillsComponent } from './admin/adminskills/editskills/editskills.component';
import { CsharpComponent } from './admin/adminskills/createskills/csharp/csharp.component';
import { FrontpageComponent } from './home/frontpage/frontpage.component';
import { AboutComponent } from './home/about/about.component';
import { ResumeComponent } from './home/resume/resume.component';
import { WorksComponent } from './home/works/works.component';
import { JwtModule } from '@auth0/angular-jwt';
import { ContactComponent } from './home/contact/contact.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    LoginComponent,
    SetupComponent,
    AdminheaderComponent,
    AdminfooterComponent,
    AdminsidebarComponent,
    DashboardComponent,
    AdminprofileComponent,
    ProfilelocationComponent,
    ProfilestatusComponent,
    ProfilecontactComponent,
    AdminworkComponent,
    CreateworkComponent,
    EditworkComponent,
    AdmineducationComponent,
    CreateeducationComponent,
    EditeducationComponent,
    AdminskillsComponent,
    CreateskillsComponent,
    CreateskillsgenreComponent,
    EditskillsComponent,
    CsharpComponent,
    FrontpageComponent,
    AboutComponent,
    ResumeComponent,
    WorksComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: () => localStorage.getItem("token"),
        allowedDomains: [window.location.host]
      },
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
