import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfilecontactComponent } from './profilecontact.component';

describe('ProfilecontactComponent', () => {
  let component: ProfilecontactComponent;
  let fixture: ComponentFixture<ProfilecontactComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfilecontactComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProfilecontactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
