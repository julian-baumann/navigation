import { StateNavigator, State } from 'navigation';
import SharedElementMotion from './SharedElementMotion';
import * as React from 'react';

interface NavigationMotionProps {
    unmountedStyle: any;
    mountedStyle: any;
    crumbStyle: any;
    duration: number;
    sharedElementMotion: (props: SharedElementNavigationMotionProps) => SharedElementMotion;
    stateNavigator?: StateNavigator;
    children: (style: any, scene: React.ReactNode, key: number, active: boolean, state: State, data: any) => React.ReactNode;
}

interface SharedElement {
    name: string;
    oldElement: { ref: HTMLElement; data: any };
    mountedElement: { ref: HTMLElement; data: any };
}

interface SharedElementNavigationMotionProps {
    sharedElements: SharedElement[];
    progress: number;
    duration: number;
}

interface SharedElementMotionProps {
    onAnimated: (name: string, ref: HTMLElement, data: any) => void;
    onAnimating: (name: string, ref: HTMLElement, data: any) => void;
    elementStyle: (name: string, ref: HTMLElement, data: any) => any;
    children: (style: any, name: string, oldElementData: any, mountedElementData: any) => React.ReactNode;
}

export { NavigationMotionProps, SharedElement, SharedElementNavigationMotionProps, SharedElementMotionProps }

