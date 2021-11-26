import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdmineducationComponent } from './admineducation.component';

describe('AdmineducationComponent', () => {
  let component: AdmineducationComponent;
  let fixture: ComponentFixture<AdmineducationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdmineducationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdmineducationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
