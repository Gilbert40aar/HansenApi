import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfilelocationComponent } from './profilelocation.component';

describe('ProfilelocationComponent', () => {
  let component: ProfilelocationComponent;
  let fixture: ComponentFixture<ProfilelocationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfilelocationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProfilelocationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
